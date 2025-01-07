using System.Text.Json;
using System.Text.Json.Serialization;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FiveRandomWords_JsonSchema_Type()
    {
        var pair = GetAuthorizedChatApi(CustomProvider.OpenAi);
        using var api = pair.Api;
        
        var response = await api.Chat.CreateChatCompletionAsAsync<WordsResponse>(
            messages: ["Generate five random words as json."],
            model: pair.Model,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.GenerateSomeJson");
        response.Value1.Should().NotBeNull();
        response.Value1!.Words.Should().NotBeEmpty();
        response.Value2.Should().NotBeNull();

        Console.WriteLine("Words:");
        foreach (var word in response.Value1!.Words)
        {
            Console.WriteLine(word);
        }
        
        Console.WriteLine("Raw Response:");
        Console.WriteLine(response.Value2!);
    }
    
    [TestMethod]
    public async Task Weather_JsonSchema_Type()
    {
        var pair = GetAuthorizedChatApi(CustomProvider.OpenAi);
        using var api = pair.Api;
        
        var response = await api.Chat.CreateChatCompletionAsAsync<Weather>(
            messages: ["Generate random weather."],
            model: pair.Model,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.GenerateSomeJson",
            jsonSerializerOptions: new JsonSerializerOptions
            {
                Converters = {new JsonStringEnumConverter()},
            });
        response.Value1.Should().NotBeNull();
        response.Value1!.Location.Should().NotBeEmpty();
        response.Value1!.Description.Should().NotBeEmpty();
        response.Value2.Should().NotBeNull();

        Console.WriteLine("Weather:");
        Console.WriteLine($"Location: {response.Value1!.Location}");
        Console.WriteLine($"Temperature: {response.Value1!.Temperature}");
        Console.WriteLine($"Unit: {response.Value1!.Unit}");
        Console.WriteLine($"Description: {response.Value1!.Description}");
        
        Console.WriteLine("Raw Response:");
        Console.WriteLine(response.Value2!);
    }
    
    [TestMethod]
    public async Task FiveRandomWords_JsonSchema_JsonTypeInfo()
    {
        var pair = GetAuthorizedChatApi(CustomProvider.OpenAi);
        using var api = pair.Api;
        
        var response = await api.Chat.CreateChatCompletionAsAsync(
            jsonTypeInfo: SourceGeneratedContext.Default.WordsResponse,
            messages: ["Generate five random words."],
            model: pair.Model,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.GenerateSomeJson");
        response.Value1.Should().NotBeNull();
        response.Value1!.Words.Should().NotBeEmpty();
        response.Value2.Should().NotBeNull();

        Console.WriteLine("Words:");
        foreach (var word in response.Value1!.Words)
        {
            Console.WriteLine(word);
        }
        
        Console.WriteLine("Raw Response:");
        Console.WriteLine(response.Value2!);
    }
    
    [TestMethod]
    public async Task Weather_JsonSchema_JsonTypeInfo()
    {
        var pair = GetAuthorizedChatApi(CustomProvider.OpenAi);
        using var api = pair.Api;
        
        var response = await api.Chat.CreateChatCompletionAsAsync(
            jsonTypeInfo: SourceGeneratedContext.Default.Weather,
            messages: ["Generate random weather."],
            model: pair.Model,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.GenerateSomeJson");
        response.Value1.Should().NotBeNull();
        response.Value1!.Location.Should().NotBeEmpty();
        response.Value1!.Description.Should().NotBeEmpty();
        response.Value2.Should().NotBeNull();

        Console.WriteLine("Weather:");
        Console.WriteLine($"Location: {response.Value1!.Location}");
        Console.WriteLine($"Temperature: {response.Value1!.Temperature}");
        Console.WriteLine($"Unit: {response.Value1!.Unit}");
        Console.WriteLine($"Description: {response.Value1!.Description}");
        
        Console.WriteLine("Raw Response:");
        Console.WriteLine(response.Value2!);
    }
}

public class WordsResponse
{
    //[JsonPropertyName("words")]
    public string[] Words { get; set; } = [];
}

[JsonSourceGenerationOptions(Converters = [typeof(JsonStringEnumConverter<Unit>)])]
[JsonSerializable(typeof(WordsResponse))]
[JsonSerializable(typeof(Weather))]
public partial class SourceGeneratedContext : JsonSerializerContext;
