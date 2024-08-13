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
}
