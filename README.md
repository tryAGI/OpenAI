# OpenAI

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.OpenAI)](https://www.nuget.org/packages/tryAGI.OpenAI/)
[![dotnet](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/OpenAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/OpenAI)](https://github.com/tryAGI/OpenAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

Generated C# SDK based on official OpenAI OpenAPI specification using NSwag

This package includes C# Source Generator which allows you to define functions natively through a C# interface,
and also provides extensions that make it easier to call this interface later.  
In addition to easy function implementation and readability,
it generates Args classes, extension methods to easily pass a functions to API,
and extension methods to simply call a function via json and return json.  
Currently only System.Text.Json is supported.  

### Usage
```csharp
using tryAGI.OpenAI;

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


var service = new WeatherService();
using var httpClient = new HttpClient();
var api = new OpenAiApi(apiKey, httpClient);
var result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Messages = new List<ChatCompletionRequestMessage>
    {
        "You are a helpful weather assistant.".AsSystemMessage(),
        "What's the weather like today?".AsUserMessage(),
    },
    Functions = service.AsFunctions(),
    Function_call = Function_call4.Auto,
    Model = ModelIds.Gpt35Turbo_0613,
});
// ...
var resultMessage = result.GetFirstChoiceMessage();
var functionArgumentsJson = resultMessage.Function_call?.Arguments ?? string.Empty;
var json = await service.CallGetCurrentWeatherAsync(functionArgumentsJson);
// or just get arguments
var args = service.AsGetCurrentWeatherAsyncArgs(functionArgumentsJson);
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