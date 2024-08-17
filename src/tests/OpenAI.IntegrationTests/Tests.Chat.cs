using System.Text.Json.Serialization;

namespace OpenAI.IntegrationTests;

public partial class Tests
{
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    [DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    [DataRow(CustomProvider.OpenRouter)]
    [DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    public async Task GenerateFiveRandomWords(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        string response = await api.Chat.CreateChatCompletionAsync(
            messages: ["Generate five random words."],
            model: pair.Model,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateChatCompletion");
        response.Should().NotBeEmpty();

        Console.WriteLine(response);
    }
    
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    [DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    [DataRow(CustomProvider.OpenRouter)]
    [DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    public async Task GenerateFiveRandomWordsAsStream(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        var enumerable = api.Chat.CreateChatCompletionAsStreamAsync(
            messages: ["Generate five random words."],
            model: pair.Model,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateChatCompletion");
        
        await foreach (string response in enumerable)
        {
            Console.WriteLine(response);
        }
    }
    
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    [DataRow(CustomProvider.Fireworks)]
    [DataRow(CustomProvider.DeepInfra)]
    [DataRow(CustomProvider.DeepSeek)]
    [DataRow(CustomProvider.OpenRouter)]
    //[DataRow(CustomProvider.Together)]
    [DataRow(CustomProvider.GitHub)]
    public async Task GenerateFiveRandomWordsAsJsonObject(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        string response = await api.Chat.CreateChatCompletionAsync(
            messages: ["Generate five random words as json."],
            model: pair.Model,
            responseFormat: new ResponseFormatJsonObject
            {
                Type = ResponseFormatJsonObjectType.JsonObject,
            },
            user: "tryAGI.OpenAI.IntegrationTests.Tests.GenerateSomeJson");
        response.Should().NotBeEmpty();

        Console.WriteLine(response);
    }
    
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    // [DataRow(CustomProvider.Fireworks)]
    // [DataRow(CustomProvider.DeepInfra)]
    // [DataRow(CustomProvider.DeepSeek)]
    // [DataRow(CustomProvider.OpenRouter)]
    // [DataRow(CustomProvider.Together)]
    // [DataRow(CustomProvider.GitHub)]
    public async Task GenerateFiveRandomWordsAsJsonSchemaUsingReflection(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
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
    
    [DataTestMethod]
    [DataRow(CustomProvider.OpenAi)]
    // [DataRow(CustomProvider.Fireworks)]
    // [DataRow(CustomProvider.DeepInfra)]
    // [DataRow(CustomProvider.DeepSeek)]
    // [DataRow(CustomProvider.OpenRouter)]
    // [DataRow(CustomProvider.Together)]
    // [DataRow(CustomProvider.GitHub)]
    public async Task GenerateFiveRandomWordsAsJsonSchemaTrimmable(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        var response = await api.Chat.CreateChatCompletionAsAsync(
            jsonTypeInfo: SourceGeneratedContext.Default.WordsResponse,
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
}
    
public class WordsResponse
{
    //[JsonPropertyName("words")]
    public string[] Words { get; set; } = [];
}

[JsonSerializable(typeof(WordsResponse))]
public partial class SourceGeneratedContext : JsonSerializerContext;
