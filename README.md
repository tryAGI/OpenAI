# OpenAI

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.OpenAI)](https://www.nuget.org/packages/tryAGI.OpenAI/)
[![dotnet](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/OpenAI)](https://github.com/tryAGI/OpenAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official OpenAI OpenAPI specification](https://raw.githubusercontent.com/openai/openai-openapi/master/openapi.yaml) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- Contains a supported list of constants such as current prices, models, and other
- Source generator to define functions natively through C# interfaces
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Support all OpenAI API endpoints including completions, chat, embeddings, images, assistants and more.
- Regularly tested for compatibility with popular custom providers like OpenRouter/DeepSeek/Ollama/LM Studio and many others
- Microsoft.Extensions.AI `IChatClient` and `IEmbeddingGenerator` support for OpenAI and all CustomProviders
- Alias-aware routed `IChatClient` builder with provider fallback and manual 429 cooldown tracking
- `FreeLLM` package for free-first chat routing across OpenAI-compatible providers and Gemini with OpenAI-compatible and MEAI surfaces

## Documentation
Examples and documentation can be found here: https://tryagi.github.io/OpenAI/

## Usage
```csharp
using var api = new OpenAiApi("API_KEY");
string response = await api.Chat.CreateChatCompletionAsync(
    messages: ["Generate five random words."],
    model: ModelIdsSharedEnum.Gpt4oMini);
Console.WriteLine(response); // "apple, banana, cherry, date, elderberry"

var enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
    messages: ["Generate five random words."],
    model: ModelIdsSharedEnum.Gpt4oMini);

await foreach (string response in enumerable)
{
    Console.WriteLine(response);
}
```
It uses three implicit conversions:
- from `string` to `ChatCompletionRequestUserMessage`. It will always be converted to the user message.
- from `ChatCompletionResponseMessage` to `string` . It will always contain the first choice message content.
- from `CreateChatCompletionStreamResponse` to `string` . It will always contain the first delta content.

You still can use the full response objects if you need more information, just replace `string response` to `var response`.

### Tools
```csharp
using OpenAI;
using CSharpToJsonSchema;

public enum Unit
{
    Celsius,
    Fahrenheit,
}

public class Weather
{
    public string Location { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public Unit Unit { get; set; }
    public string Description { get; set; } = string.Empty;
}

[GenerateJsonSchema(Strict = true)] // false by default. You can't use parameters with default values in Strict mode.
public interface IWeatherFunctions
{
    [Description("Get the current weather in a given location")]
    public Task<Weather> GetCurrentWeatherAsync(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit unit,
        CancellationToken cancellationToken = default);
}

public class WeatherService : IWeatherFunctions
{
    public Task<Weather> GetCurrentWeatherAsync(string location, Unit unit = Unit.Celsius, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(new Weather
        {
            Location = location,
            Temperature = 22.0,
            Unit = unit,
            Description = "Sunny",
        });
    }
}

using var api = new OpenAiApi("API_KEY");

var service = new WeatherService();
var tools = service.AsTools().AsOpenAiTools();

var messages = new List<ChatCompletionRequestMessage>
{
    "You are a helpful weather assistant.".AsSystemMessage(),
    "What is the current temperature in Dubai, UAE in Celsius?".AsUserMessage(),
};
var model = ModelIdsSharedEnum.Gpt4oMini;
var result = await api.Chat.CreateChatCompletionAsync(
    messages,
    model: model,
    tools: tools);
var resultMessage = result.Choices.First().Message;
messages.Add(resultMessage.AsRequestMessage());

foreach (var call in resultMessage.ToolCalls)
{
    var json = await service.CallAsync(
        functionName: call.Function.Name,
        argumentsAsJson: call.Function.Arguments);
    messages.Add(json.AsToolMessage(call.Id));
}

var result = await api.Chat.CreateChatCompletionAsync(
    messages,
    model: model,
    tools: tools);
var resultMessage = result.Choices.First().Message;
messages.Add(resultMessage.AsRequestMessage());
```
```
> System: 
You are a helpful weather assistant.
> User: 
What is the current temperature in Dubai, UAE in Celsius?
> Assistant: 
call_3sptsiHzKnaxF8bs8BWxPo0B:
GetCurrentWeather({"location":"Dubai, UAE","unit":"celsius"})
> Tool(call_3sptsiHzKnaxF8bs8BWxPo0B):
{"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
> Assistant: 
The current temperature in Dubai, UAE is 22°C with sunny weather.
```

### Structured Outputs
```csharp
using OpenAI;

using var api = new OpenAiApi("API_KEY");

var response = await api.Chat.CreateChatCompletionAsAsync<Weather>(
    messages: ["Generate random weather."],
    model: ModelIdsSharedEnum.Gpt4oMini,
    jsonSerializerOptions: new JsonSerializerOptions
    {
        Converters = {new JsonStringEnumConverter()},
    });
// or (if you need trimmable/NativeAOT version)
var response = await api.Chat.CreateChatCompletionAsAsync(
    jsonTypeInfo: SourceGeneratedContext.Default.Weather,
    messages: ["Generate random weather."],
    model: ModelIdsSharedEnum.Gpt4oMini);

// response.Value1 contains the structured output
// response.Value2 contains the CreateChatCompletionResponse object
```
```
Weather:
Location: San Francisco, CA
Temperature: 65
Unit: Fahrenheit
Description: Partly cloudy with a light breeze and occasional sunshine.
Raw Response:
{"Location":"San Francisco, CA","Temperature":65,"Unit":"Fahrenheit","Description":"Partly cloudy with a light breeze and occasional sunshine."}
```
Additional code for trimmable/NativeAOT version:
```csharp
[JsonSourceGenerationOptions(Converters = [typeof(JsonStringEnumConverter<Unit>)])]
[JsonSerializable(typeof(Weather))]
public partial class SourceGeneratedContext : JsonSerializerContext;
```

### Custom providers
```csharp
using OpenAI;

using var api = CustomProviders.GitHubModels("GITHUB_TOKEN");
using var api = CustomProviders.Azure("API_KEY", "ENDPOINT");
using var api = CustomProviders.DeepInfra("API_KEY");
using var api = CustomProviders.Groq("API_KEY");
using var api = CustomProviders.XAi("API_KEY");
using var api = CustomProviders.DeepSeek("API_KEY");
using var api = CustomProviders.Fireworks("API_KEY");
using var api = CustomProviders.OpenRouter("API_KEY");
using var api = CustomProviders.Together("API_KEY");
using var api = CustomProviders.Perplexity("API_KEY");
using var api = CustomProviders.SambaNova("API_KEY");
using var api = CustomProviders.Mistral("API_KEY");
using var api = CustomProviders.Codestral("API_KEY");
using var api = CustomProviders.Cerebras("API_KEY");
using var api = CustomProviders.Cohere("API_KEY");
using var api = CustomProviders.Ollama();
using var api = CustomProviders.LmStudio();
```

### Microsoft.Extensions.AI

The client natively implements [`IChatClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient) and [`IEmbeddingGenerator<string, Embedding<float>>`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.iembeddinggenerator-2) from [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI.Abstractions), providing a unified interface across 15+ providers:
```csharp
using OpenAI;
using Microsoft.Extensions.AI;

// Works with OpenAI and all CustomProviders (Azure, DeepSeek, Groq, etc.)
using var client = new OpenAiClient("API_KEY");
// or: using var client = CustomProviders.Groq("API_KEY");

// IChatClient
IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    "Say hello!",
    new ChatOptions { ModelId = "gpt-4o-mini" });
Console.WriteLine(response.Messages[0].Text);

// Streaming
await foreach (var update in chatClient.GetStreamingResponseAsync(
    "Count to 5.",
    new ChatOptions { ModelId = "gpt-4o-mini" }))
{
    Console.Write(string.Concat(update.Contents.OfType<TextContent>().Select(c => c.Text)));
}

// IEmbeddingGenerator
IEmbeddingGenerator<string, Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions { ModelId = "text-embedding-3-small" });
```

### Routed chat client

For OpenAI-compatible providers, you can build one routed `IChatClient` with aliases like `smart`, `smart-any`, `fast`, and `cheap`.

```csharp
using Microsoft.Extensions.AI;
using tryAGI.OpenAI;

using var routed = new OpenAiRoutedChatClientBuilder()
    .AddProvider("cerebras", CustomProviders.Cerebras("CEREBRAS_API_KEY"), provider => provider
        .AddModel("qwen-3-235b-a22b-instruct-2507", model => model
            .AsSmart(priority: 100)
            .AsSmartAny(priority: 100)
            .SupportsToolCalls()
            .SupportsStructuredOutputs()
            .IsRecurringFree()))
    .AddProvider("groq", CustomProviders.Groq("GROQ_API_KEY"), provider => provider
        .AddModel("llama-3.3-70b-versatile", model => model
            .AsFast(priority: 100)
            .AsCheap(priority: 70)
            .AsSmartAny(priority: 60)
            .SupportsToolCalls()))
    .AddProvider("openrouter", CustomProviders.OpenRouter("OPENROUTER_API_KEY"), provider => provider
        .WithRateLimitCooldown(TimeSpan.FromMinutes(2))
        .AddModel("openrouter/free", model => model
            .AsCheap(priority: 100)
            .AsSmartAny(priority: 40)))
    .Build();

IChatClient chatClient = routed;

var response = await chatClient.GetResponseAsync(
    "Explain the tradeoffs of vector search vs keyword search.",
    new ChatOptions { ModelId = OpenAiModelAliases.Smart });

Console.WriteLine(response.Messages[0].Text);
```

Notes:
- This router is for providers exposed through `CustomProviders`, i.e. OpenAI-compatible endpoints.
- Provider cooldowns are tracked automatically from `429` responses and common rate-limit headers.
- If `smart` is exhausted, the router also considers models tagged with `smart-any`.

### FreeLLM

`FreeLLM` is a separate package in this repo. It depends on `tryAGI.OpenAI` and `Google_Gemini`, and gives you one routed chat client across OpenAI-compatible providers and Gemini.

```xml
<PackageReference Include="FreeLLM" Version="x.y.z" />
```

```csharp
using Microsoft.Extensions.AI;
using FreeLLM;
using tryAGI.OpenAI;

using var client = new FreeLlmClientBuilder()
    .WithCatalogRefresh(TimeSpan.FromHours(6), routeDiscoveredModels: true)
    // Curated defaults are applied automatically for popular providers.
    .AddCerebras("CEREBRAS_API_KEY")
    .AddGemini("GEMINI_API_KEY", provider => provider
        .WithPriority(320)
        .AddModel("gemini-2.5-flash", model => model
            .AsSmart(priority: 190)
            .AsSmartAny(priority: 190)
            .AsFast(priority: 140))
        .AddModel("gemini-2.5-flash-lite", model => model
            .AsCheap(priority: 220)))
    .AddOpenRouter("OPENROUTER_API_KEY", provider => provider
        .WithPriority(90)
        .RemoveModel("openrouter/free")
        .AddModel("openrouter/free", model => model
            .AsCheap(priority: 250)))
    .Build();

// OpenAI-compatible chat completions API
var raw = await client.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Value2 = new CreateChatCompletionRequestVariant2
    {
        Model = FreeLlmModelAliases.Smart,
        Messages = ["Explain vector search vs keyword search."],
    },
});

// Microsoft.Extensions.AI API
IChatClient chatClient = client;
var meai = await chatClient.GetResponseAsync(
    "Explain vector search vs keyword search.",
    new ChatOptions { ModelId = FreeLlmModelAliases.SmartAny });

Console.WriteLine(raw.Choices[0].Message.Content);
Console.WriteLine(meai.Messages[0].Text);

var catalogs = client.GetProviderCatalogs();
foreach (var catalog in catalogs)
{
    Console.WriteLine($"{catalog.ProviderId}: refreshed={catalog.RefreshedAt:O}, missing={string.Join(", ", catalog.MissingConfiguredModelIds)}");
}
```

Notes:
- `FreeLlmModelAliases` includes `smart`, `smart-any`, `fast`, and `cheap`.
- Convenience methods for Gemini, Cerebras, SambaNova, OpenRouter, GitHub Models, Groq, and NVIDIA register curated default models and priorities.
- Use `provider.WithPriority(...)` to bias whole providers, and `model.AsSmart(...)`, `model.AsCheap(...)`, `model.AsFast(...)`, and `model.AsSmartAny(...)` to tune alias-specific model priority.
- Use `builder.WithCatalogRefresh(...)` or `provider.WithCatalogRefresh(...)` to periodically call provider model catalogs, mark configured models as missing when they disappear, and optionally route newly discovered models when `routeDiscoveredModels: true`.
- Use `client.RefreshProviderCatalogsAsync()` to force a catalog refresh and `client.GetProviderCatalogs()` to inspect configured, discovered, present, missing, and routable models per provider.
- Use `provider.ClearModels()` or pass `useDefaultModels: false` to a convenience method if you want a fully manual model list.
- `provider.AddModel("existing-model", ...)` updates preset models in place, so you can override defaults without duplicating registrations.
- `client.Chat` preserves raw OpenAI-compatible requests for OpenAI-compatible providers and translates supported chat-completions requests to Gemini when a Gemini model wins routing.
- Gemini translation currently supports `CreateChatCompletionRequestVariant2`, single-choice text chat, JSON response formats, and data-URI images.
- Raw OpenAI tool schemas/functions, audio/modalities, logprobs, web search, prediction, and remote image URLs are not translated to Gemini; use the MEAI surface for Gemini tool calling.
- Provider cooldowns and last-seen rate-limit data are available through `client.GetProviderStatuses()`.

### Constants
All `tryGetXXX` methods return `null` if the value is not found.  
There also non-try methods that throw an exception if the value is not found.
```cs
using OpenAI;

// You can try to get the enum from string using:
var model = ModelIdsSharedEnumExtensions.ToEnum("gpt-4o") ?? throw new Exception("Invalid model");

// Chat
var model = ModelIdsSharedEnum.Gpt4oMini;
double? priceInUsd = model.TryGetPriceInUsd(
    inputTokens: 500,
    outputTokens: 500)
double? priceInUsd = model.TryGetFineTunePriceInUsd(
    trainingTokens: 500,
    inputTokens: 500,
    outputTokens: 500)
int contextLength = model.TryGetContextLength() // 128_000
int outputLength = model.TryGetOutputLength() // 16_000

// Embeddings
var model = CreateEmbeddingRequestModel.TextEmbedding3Small;
int? maxInputTokens = model.TryGetMaxInputTokens() // 8191
double? priceInUsd = model.TryGetPriceInUsd(tokens: 500)

// Images
double? priceInUsd = CreateImageRequestModel.DallE3.TryGetPriceInUsd(
    size: CreateImageRequestSize.x1024x1024,
    quality: CreateImageRequestQuality.Hd)

// Speech to Text
double? priceInUsd = CreateTranscriptionRequestModel.Whisper1.TryGetPriceInUsd(
    seconds: 60)

// Text to Speech
double? priceInUsd = CreateSpeechRequestModel.Tts1Hd.TryGetPriceInUsd(
    characters: 1000)
```

<!-- EXAMPLES:START -->
### Chat Completion
Send a simple chat completion request.

```csharp
using var client = new OpenAiClient(apiKey);

string response = await client.Chat.CreateChatCompletionAsync(
    new CreateChatCompletionRequest
    {
        Value2 = new CreateChatCompletionRequestVariant2
        {
            Messages = ["Generate five random words."],
            Model = "gpt-4o-mini",
        }
    });

Console.WriteLine(response);
```

### Chat Completion Streaming
Stream a chat completion response token by token.

```csharp
using var client = new OpenAiClient(apiKey);

var enumerable = client.Chat.CreateChatCompletionAsStreamAsync(
    new CreateChatCompletionRequest
    {
        Value2 = new CreateChatCompletionRequestVariant2
        {
            Messages = ["Generate five random words."],
            Model = "gpt-4o-mini",
        }
    });

await foreach (string response in enumerable)
{
    Console.Write(response);
}
```

### Chat With Vision
Send an image to the model for analysis.

```csharp
using var client = new OpenAiClient(apiKey);

CreateChatCompletionResponse response = await client.Chat.CreateChatCompletionAsync(
    new CreateChatCompletionRequest
    {
        Value2 = new CreateChatCompletionRequestVariant2
        {
            Messages = [
                "Please describe the following image.",
                H.Resources.images_dog_and_cat_png.AsBytes().AsUserMessage(mimeType: "image/png"),
            ],
            Model = "gpt-4o-mini",
        }
    });

Console.WriteLine(response.Choices[0].Message.Content);
```

### JSON Response Format
Request a response in JSON format.

```csharp
using var client = new OpenAiClient(apiKey);

string response = await client.Chat.CreateChatCompletionAsync(
    new CreateChatCompletionRequest
    {
        Value2 = new CreateChatCompletionRequestVariant2
        {
            Messages = ["Generate five random words as json."],
            Model = "gpt-4o-mini",
            ResponseFormat = new ResponseFormatJsonObject
            {
                Type = ResponseFormatJsonObjectType.JsonObject,
            },
        }
    });

Console.WriteLine(response);
```

### Structured Outputs
Get structured JSON responses using a C# type as the schema.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Chat.CreateChatCompletionAsAsync<WordsResponse>(
    messages: ["Generate five random words as json."],
    model: "gpt-4o-mini");

Console.WriteLine("Words:");
foreach (var word in response.Value1!.Words)
{
    Console.WriteLine(word);
}
```

### Structured Outputs (AOT)
Get structured JSON responses using a JsonTypeInfo for AOT/trimming compatibility.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Chat.CreateChatCompletionAsAsync(
    jsonTypeInfo: SourceGeneratedContext.Default.WordsResponse,
    messages: ["Generate five random words."],
    model: "gpt-4o-mini");

Console.WriteLine("Words:");
foreach (var word in response.Value1!.Words)
{
    Console.WriteLine(word);
}
```

### Embeddings
Create a text embedding vector.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Embeddings.CreateEmbeddingAsync(
    input: "Hello, world",
    model: CreateEmbeddingRequestModel.TextEmbedding3Small);

foreach (var data in response.Data.ElementAt(0).Embedding1)
{
    Console.WriteLine($"{data}");
}
```

### Image Generation
Generate an image from a text prompt.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Images.CreateImageAsync(
    prompt: "a white siamese cat",
    model: CreateImageRequestModel.GptImage1Mini,
    n: 1,
    quality: CreateImageRequestQuality.Low,
    size: CreateImageRequestSize.x1024x1024,
    outputFormat: CreateImageRequestOutputFormat.Png);

var base64 = response.Data?.ElementAt(0).B64Json;

Console.WriteLine($"Generated image ({base64?.Length} base64 chars)");
```

### Text To Speech
Convert text to speech audio using streaming.

```csharp
using var client = new OpenAiClient(apiKey);

using var memoryStream = new MemoryStream();
await foreach (var streamEvent in client.Audio.CreateSpeechAsync(
    model: CreateSpeechRequestModel.Gpt4oMiniTts,
    input: "Hello! This is a text-to-speech test.",
    voice: (VoiceIdsShared)VoiceIdsSharedEnum.Alloy,
    responseFormat: CreateSpeechRequestResponseFormat.Mp3,
    speed: 1.0,
    streamFormat: CreateSpeechRequestStreamFormat.Sse))
{
    if (streamEvent.SpeechAudioDelta is { } delta)
    {
        byte[] chunk = Convert.FromBase64String(delta.Audio);
        memoryStream.Write(chunk, 0, chunk.Length);
    }
}

byte[] audio = memoryStream.ToArray();

Console.WriteLine($"Generated {audio.Length} bytes of audio.");
```

### List Models
List all available models.

```csharp
using var client = new OpenAiClient(apiKey);

var models = await client.Models.ListModelsAsync();

foreach (var model in models.Data)
{
    Console.WriteLine(model.Id);
}
```

### Moderation
Check text for policy violations using the moderation endpoint.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Moderations.CreateModerationAsync(
    input: "Hello, world",
    model: CreateModerationRequestModel.OmniModerationLatest);

Console.WriteLine($"Flagged: {response.Results.First().Flagged}");
```

### MEAI Chat Completion
Use the Microsoft.Extensions.AI IChatClient interface for chat completions.

```csharp
using var client = new OpenAiClient(apiKey);

// using Meai = Microsoft.Extensions.AI;
Meai.IChatClient chatClient = client;

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "Say hello in exactly 3 words."),
};

var response = await chatClient.GetResponseAsync(
    messages,
    new Meai.ChatOptions { ModelId = "gpt-4o-mini" });

Console.WriteLine(response.Messages[0].Text);
```

### MEAI Chat Streaming
Stream a chat completion using the Microsoft.Extensions.AI IChatClient interface.

```csharp
using var client = new OpenAiClient(apiKey);

// using Meai = Microsoft.Extensions.AI;
Meai.IChatClient chatClient = client;

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "Count from 1 to 5."),
};

await foreach (var update in chatClient.GetStreamingResponseAsync(
    messages,
    new Meai.ChatOptions { ModelId = "gpt-4o-mini" }))
{
    var text = string.Concat(update.Contents.OfType<Meai.TextContent>().Select(c => c.Text));
    if (!string.IsNullOrEmpty(text))
    {
        Console.Write(text);
    }
}
```

### MEAI Tool Calling
Use function/tool calling via the Microsoft.Extensions.AI IChatClient interface.

```csharp
using var client = new OpenAiClient(apiKey);

// using Meai = Microsoft.Extensions.AI;
Meai.IChatClient chatClient = client;

var tool = Meai.AIFunctionFactory.Create(
    (string city) => city switch
    {
        "Paris" => "22C, sunny",
        "London" => "15C, cloudy",
        _ => "Unknown",
    },
    name: "GetWeather",
    description: "Gets the current weather for a city");

var chatOptions = new Meai.ChatOptions
{
    ModelId = "gpt-4o-mini",
    Tools = [tool],
};

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "What's the weather in Paris? Respond with the temperature only."),
};

// First turn: get tool call
var response = await chatClient.GetResponseAsync(
    (IEnumerable<Meai.ChatMessage>)messages, chatOptions);

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<Meai.FunctionCallContent>()
    .First();

// Execute tool and add result
var toolResult = await tool.InvokeAsync(
    functionCall.Arguments is { } args
        ? new Meai.AIFunctionArguments(args)
        : null);
messages.AddRange(response.Messages);
messages.Add(new Meai.ChatMessage(Meai.ChatRole.Tool,
    new Meai.AIContent[]
    {
        new Meai.FunctionResultContent(functionCall.CallId, toolResult),
    }));

// Second turn: get final response
var finalResponse = await chatClient.GetResponseAsync(
    (IEnumerable<Meai.ChatMessage>)messages, chatOptions);

Console.WriteLine(finalResponse.Messages[0].Text);
```

### MEAI Embeddings
Generate embeddings using the Microsoft.Extensions.AI IEmbeddingGenerator interface.

```csharp
using var client = new OpenAiClient(apiKey);

// using Meai = Microsoft.Extensions.AI;
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var result = await generator.GenerateAsync(
    new List<string> { "Hello, world!" },
    new Meai.EmbeddingGenerationOptions
    {
        ModelId = "text-embedding-3-small",
    });

Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/OpenAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/OpenAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
