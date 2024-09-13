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
    [DataRow(CustomProvider.Perplexity)]
    [DataRow(CustomProvider.SambaNova)]
    public async Task GenerateFiveRandomWords(CustomProvider customProvider)
    {
        var pair = GetAuthorizedChatApi(customProvider);
        using var api = pair.Api;
        
        string response = await api.Chat.CreateChatCompletionAsync(
            messages: ["Generate five random words."],
            model: pair.Model,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateChatCompletion",
            frequencyPenalty: customProvider switch
            {
                CustomProvider.Perplexity => 0.5,
                _ => null,
            },
            logprobs: null);
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
    [DataRow(CustomProvider.SambaNova)]
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
}
