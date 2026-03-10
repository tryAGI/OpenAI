# OpenAI

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.OpenAI)](https://www.nuget.org/packages/tryAGI.OpenAI/)
[![dotnet](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/OpenAI)](https://github.com/tryAGI/OpenAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)
![CodeRabbit Pull Request Reviews](https://img.shields.io/coderabbit/prs/github/tryAGI/OpenAI)

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

## Support

Priority place for bugs: https://github.com/tryAGI/OpenAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/OpenAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).