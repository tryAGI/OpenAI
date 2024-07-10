# OpenAI

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.OpenAI)](https://www.nuget.org/packages/tryAGI.OpenAI/)
[![dotnet](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/OpenAI)](https://github.com/tryAGI/OpenAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official OpenAI OpenAPI specification](https://raw.githubusercontent.com/openai/openai-openapi/master/openapi.yaml) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- Contains a supported list of constants such as current prices, models, and other
- Source generator to define functions natively through C# interfaces

### Usage
```csharp
using OpenAI;

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

[OpenAiFunctions]
public interface IWeatherFunctions
{
    [Description("Get the current weather in a given location")]
    public Task<Weather> GetCurrentWeatherAsync(
        [Description("The city and state, e.g. San Francisco, CA")] string location,
        Unit unit = Unit.Celsius,
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

using var api = new OpenAiApi();
api.AuthorizeUsingBearer(apiKey);

var service = new WeatherService();
var tools = service.AsTools();

var messages = new List<ChatCompletionRequestMessage>
{
    "You are a helpful weather assistant.".AsSystemMessage(),
    "What is the current temperature in Dubai, UAE in Celsius?".AsUserMessage(),
};
var model = ChatModels.Gpt35Turbo.Id;
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

### Constants
This repository contains the library with constants 
for all OpenAI constants(models/prices/context length and other).
```cs
using OpenAI.Constants;

string id = EmbeddingModels.Version3Small; // implicit conversion to string
double price = EmbeddingModels.Version3Small.GetPriceInUsd(tokens: 500); // 0.00001
EmbeddingModels.Version3Small.MaxInputTokens // 8191
EmbeddingModels.Version3Small.PricePerTokenInUsd // 0.00000002
```

## Support

Priority place for bugs: https://github.com/tryAGI/OpenAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/OpenAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  