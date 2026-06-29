#nullable enable
#pragma warning disable MEAI001

using System.Net;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TextToSpeechClient_GetService_Metadata()
    {
        using var client = new OpenAiClient("test-api-key");
        ITextToSpeechClient ttsClient = client;

        var metadata = ttsClient.GetService<TextToSpeechClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("openai");
        metadata.DefaultModelId.Should().Be("gpt-4o-mini-tts");
        metadata.ProviderUri.Should().NotBeNull();
        ttsClient.GetService<OpenAiClient>().Should().BeSameAs(client);
    }

    [TestMethod]
    public async Task TextToSpeechClient_MapsOptionsToCreateSpeechRequest()
    {
        var handler = new StaticResponseHandler(HttpStatusCode.OK, [1, 2, 3], "audio/wav");
        using var client = new OpenAiClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(OpenAiClient.DefaultBaseUrl),
            });
        ITextToSpeechClient ttsClient = client;
        CreateSpeechRequest? capturedRequest = null;

        var response = await ttsClient.GetAudioAsync(
            "Hello from OpenAI speech.",
            new TextToSpeechOptions
            {
                ModelId = "gpt-4o-mini-tts",
                VoiceId = "coral",
                AudioFormat = "wav",
                Language = "fr",
                Speed = 1.2f,
                AdditionalProperties = new()
                {
                    [OpenAiTextToSpeechPropertyNames.Instructions] = "Speak with warm, clear energy.",
                },
                RawRepresentationFactory = _ =>
                {
                    capturedRequest = new CreateSpeechRequest
                    {
                        Model = string.Empty,
                        Input = string.Empty,
                        Voice = VoiceIdsOrCustomVoice.FromShared(VoiceIdsShared.FromVoiceIdsSharedVariant1(string.Empty)),
                    };

                    return capturedRequest;
                },
            });

        capturedRequest.Should().NotBeNull();
        capturedRequest!.Model.Value2.Should().Be(CreateSpeechRequestModel.Gpt4oMiniTts);
        capturedRequest.Input.Should().Be("Hello from OpenAI speech.");
        capturedRequest.Voice.ToString().Should().Be("coral");
        capturedRequest.ResponseFormat.Should().Be(CreateSpeechRequestResponseFormat.Wav);
        capturedRequest.Speed.Should().BeApproximately(1.2, 0.00001);
        capturedRequest.Instructions.Should().Be("Speak with warm, clear energy.");
        capturedRequest.AdditionalProperties["language"].Should().Be("fr");

        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.AbsoluteUri.Should().Be("https://api.openai.com/v1/audio/speech");
        handler.LastRequest.Headers.Authorization!.Scheme.Should().Be("Bearer");
        handler.LastRequest.Headers.Authorization.Parameter.Should().Be("test-api-key");

        response.Contents.OfType<DataContent>().Single().Data.ToArray().Should().Equal([1, 2, 3]);
        response.ModelId.Should().Be("gpt-4o-mini-tts");
        response.AdditionalProperties!["response_format"].Should().Be("wav");

        using var document = JsonDocument.Parse(handler.LastRequestBody!);
        document.RootElement.GetProperty("model").GetString().Should().Be("gpt-4o-mini-tts");
        document.RootElement.GetProperty("input").GetString().Should().Be("Hello from OpenAI speech.");
        document.RootElement.GetProperty("voice").GetString().Should().Be("coral");
        document.RootElement.GetProperty("response_format").GetString().Should().Be("wav");
        document.RootElement.GetProperty("instructions").GetString().Should().Be("Speak with warm, clear energy.");
        document.RootElement.GetProperty("language").GetString().Should().Be("fr");
    }

    [TestMethod]
    public async Task TextToSpeechClient_StreamsAudioChunks()
    {
        var handler = new StaticResponseHandler(HttpStatusCode.OK, [1, 2, 3, 4], "audio/mpeg");
        using var client = new OpenAiClient(
            "test-api-key",
            new HttpClient(handler)
            {
                BaseAddress = new Uri(OpenAiClient.DefaultBaseUrl),
            });
        ITextToSpeechClient ttsClient = client;

        var updates = new List<TextToSpeechResponseUpdate>();
        await foreach (var update in ttsClient.GetStreamingAudioAsync(
            "Streaming OpenAI speech.",
            new TextToSpeechOptions
            {
                ModelId = "gpt-4o-mini-tts",
                VoiceId = "coral",
                AudioFormat = "mp3",
            }))
        {
            updates.Add(update);
        }

        handler.LastRequest.Should().NotBeNull();
        handler.LastRequest!.RequestUri!.AbsoluteUri.Should().Be("https://api.openai.com/v1/audio/speech");
        using var document = JsonDocument.Parse(handler.LastRequestBody!);
        document.RootElement.GetProperty("stream_format").GetString().Should().Be("audio");
        updates.First().Kind.Should().Be(TextToSpeechResponseUpdateKind.SessionOpen);
        updates.Should().Contain(static update => update.Kind == TextToSpeechResponseUpdateKind.AudioUpdating);
        updates.Should().Contain(static update => update.Kind == TextToSpeechResponseUpdateKind.AudioUpdated);
        updates.Last().Kind.Should().Be(TextToSpeechResponseUpdateKind.SessionClose);
    }

    private sealed class StaticResponseHandler(
        HttpStatusCode statusCode,
        byte[] responseBody,
        string mediaType) : HttpMessageHandler
    {
        public HttpRequestMessage? LastRequest { get; private set; }
        public string? LastRequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            LastRequest = request;
            LastRequestBody = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            return new HttpResponseMessage(statusCode)
            {
                RequestMessage = request,
                Content = new ByteArrayContent(responseBody)
                {
                    Headers =
                    {
                        ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mediaType),
                    },
                },
            };
        }
    }
}
