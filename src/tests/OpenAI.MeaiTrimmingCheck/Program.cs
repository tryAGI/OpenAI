#pragma warning disable MEAI001
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using tryAGI.OpenAI;
using Meai = Microsoft.Extensions.AI;

if (JsonSerializer.IsReflectionEnabledByDefault)
    throw new InvalidOperationException("Reflection serialization must be disabled.");

using var handler = new ContractHandler();
using var http = new HttpClient(handler) { BaseAddress = new Uri(OpenAiClient.DefaultBaseUrl) };

#if PROBE_Chat
using var client = new OpenAiClient("offline", http);
Meai.IChatClient chat = client;
using var schemaDocument = JsonDocument.Parse("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"],"additionalProperties":false}""");
var options = new Meai.ChatOptions
{
    ModelId = "fixture",
    ResponseFormat = Meai.ChatResponseFormat.ForJsonSchema(schemaDocument.RootElement, "answer", "fixture schema"),
    Tools = [new LookupFunction()],
};
var response = await chat.GetResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "ping")], options);
Require(response.Text == "pong", "MEAI chat content");
using (var request = JsonDocument.Parse(handler.LastBody!))
{
    Require(request.RootElement.GetProperty("response_format").GetProperty("json_schema").GetProperty("schema").GetProperty("properties").GetProperty("city").GetProperty("type").GetString() == "string", "Structured schema");
    Require(request.RootElement.GetProperty("tools")[0].GetProperty("function").GetProperty("parameters").GetProperty("properties").GetProperty("city").GetProperty("type").GetString() == "string", "Function schema");
}
var text = new StringBuilder();
await foreach (var update in chat.GetStreamingResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "ping")], options))
    text.Append(update.Text);
Require(text.ToString() == "pong", "MEAI streaming content");
#elif PROBE_TypedChat
using var client = new ChatClient(httpClient: http);
client.Authorizations.Add(new EndPointAuthorization { Type = "Http", SchemeId = "ApiKeyAuth", Location = "Header", Name = "Bearer", Value = "offline" });
var response = await client.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    ModelResponseProperties = new CreateModelResponseProperties(),
    CreateChatCompletionRequestVariant2 = new CreateChatCompletionRequestVariant2
    {
        Model = "fixture",
        Messages = [new ChatCompletionRequestUserMessage { Content = "ping", Role = ChatCompletionRequestUserMessageRole.User }],
    },
});
Require(response.Choices[0].Message.Content == "pong", "Typed chat content");
#elif PROBE_Tools
IList<CSharpToJsonSchema.Tool> tools = [new()
{
    Name = "lookup",
    Description = "Lookup city",
    Parameters = new CSharpToJsonSchema.OpenApiSchema { Description = "lookup parameters" },
}];
var converted = tools.AsOpenAiTools();
Require(converted[0].Function.Name == "lookup", "Tool name");
using var parameters = JsonDocument.Parse(converted[0].Function.Parameters!.ToJson());
Require(parameters.RootElement.GetProperty("description").GetString() == "lookup parameters", "External tool schema");
#elif PROBE_Schema
var schema = TypeToSchemaHelpers2.AsResponseFormat(ProbeContext.Default.Answer, strict: true);
using var document = JsonDocument.Parse(schema.Schema!.ToJson());
Require(document.RootElement.GetProperty("properties").TryGetProperty("city", out _), "AOT structured output helper");
#elif PROBE_Speech || PROBE_CustomSpeech
using var client = new OpenAiClient("offline", http);
#if PROBE_CustomSpeech
client.JsonSerializerContext = new ExplicitSpeechContext(new JsonSerializerOptions());
#endif
Meai.ITextToSpeechClient speech = client;
var response = await speech.GetAudioAsync("fixture speech", new Meai.TextToSpeechOptions { ModelId = "gpt-4o-mini-tts", VoiceId = "coral", AudioFormat = "wav" });
Require(response.Contents.OfType<Meai.DataContent>().Single().Data.Span.SequenceEqual(new byte[] { 1, 2, 3 }), "MEAI speech bytes");
using var request = JsonDocument.Parse(handler.LastBody!);
Require(request.RootElement.GetProperty("input").GetString() == "fixture speech", "Speech input");
#if PROBE_CustomSpeech
Require(request.RootElement.GetProperty("custom").GetBoolean(), "Explicit caller context");
#else
Require(request.RootElement.GetProperty("voice").GetString() == "coral", "Speech voice");
#endif
#elif PROBE_TypedSpeech
using var client = new AudioClient(httpClient: http);
client.Authorizations.Add(new EndPointAuthorization { Type = "Http", SchemeId = "ApiKeyAuth", Location = "Header", Name = "Bearer", Value = "offline" });
var response = await client.CreateSpeechAsync(CreateSpeechRequest.FromJson("""{"model":"gpt-4o-mini-tts","input":"fixture speech","voice":"coral","response_format":"wav"}""")!);
Require(response.AsSpan().SequenceEqual(new byte[] { 1, 2, 3 }), "Typed speech bytes");
#else
#error Unknown ProbeScenario
#endif

Console.WriteLine("offline-meai-contract-passed");
return;

static void Require(bool condition, string contract)
{
    if (!condition) throw new InvalidOperationException(contract);
}

sealed class ContractHandler : HttpMessageHandler
{
    public string? LastBody { get; private set; }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Method != HttpMethod.Post || request.RequestUri?.Host != "api.openai.com")
            throw new InvalidOperationException("Unexpected offline request");
        LastBody = await request.Content!.ReadAsStringAsync(cancellationToken);
        if (request.RequestUri.AbsolutePath == "/v1/audio/speech")
            return new(HttpStatusCode.OK) { Content = new ByteArrayContent([1, 2, 3]) { Headers = { ContentType = new("audio/wav") } } };
        if (request.RequestUri.AbsolutePath != "/v1/chat/completions")
            throw new InvalidOperationException("Unexpected endpoint");
        using var body = JsonDocument.Parse(LastBody);
        var stream = body.RootElement.TryGetProperty("stream", out var streaming) && streaming.GetBoolean();
        var json = stream
            ? "data: {\"id\":\"fixture\",\"choices\":[{\"index\":0,\"delta\":{\"role\":\"assistant\",\"content\":\"pong\"},\"finish_reason\":\"stop\"}],\"created\":1,\"model\":\"fixture\",\"object\":\"chat.completion.chunk\"}\n\ndata: [DONE]\n\n"
            : """{"id":"fixture","choices":[{"finish_reason":"stop","index":0,"message":{"content":"pong","role":"assistant","refusal":null,"annotations":[]},"logprobs":null}],"created":1,"model":"fixture","object":"chat.completion"}""";
        return new(HttpStatusCode.OK) { Content = new StringContent(json, Encoding.UTF8, stream ? "text/event-stream" : "application/json") };
    }
}

#if PROBE_Chat
sealed class LookupFunction : Meai.AIFunction
{
    public override string Name => "lookup";
    public override string Description => "Lookup city";
    public override JsonElement JsonSchema => JsonDocument.Parse("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"]}""").RootElement.Clone();
    protected override ValueTask<object?> InvokeCoreAsync(Meai.AIFunctionArguments arguments, CancellationToken cancellationToken) => ValueTask.FromResult<object?>("unused");
}
#endif

#if PROBE_Schema
sealed record Answer([property: JsonPropertyName("city")] string City);
[JsonSerializable(typeof(Answer))]
internal partial class ProbeContext : JsonSerializerContext;
#endif

#if PROBE_CustomSpeech
sealed class ExplicitSpeechContext(JsonSerializerOptions options) : JsonSerializerContext(options)
{
    protected override JsonSerializerOptions? GeneratedSerializerOptions => null;
    public override JsonTypeInfo? GetTypeInfo(Type type) => type == typeof(CreateSpeechRequest)
        ? JsonMetadataServices.CreateValueInfo<CreateSpeechRequest>(Options, new SpeechConverter())
        : null;
}
sealed class SpeechConverter : JsonConverter<CreateSpeechRequest>
{
    public override CreateSpeechRequest? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotSupportedException();
    public override void Write(Utf8JsonWriter writer, CreateSpeechRequest value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("input", value.Input);
        writer.WriteBoolean("custom", true);
        writer.WriteEndObject();
    }
}
#endif
