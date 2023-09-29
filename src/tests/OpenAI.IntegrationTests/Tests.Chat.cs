namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateChatCompletion()
    {
        var api = GetAuthorizedApi();
        var response = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Messages = new List<ChatCompletionRequestMessage>
            {
                "You are a helpful weather assistant.".AsSystemMessage(),
                "What's the weather like today?".AsUserMessage(),
            },
            Model = ModelIds.Gpt35Turbo_0613,
            User = "tryAGI.OpenAI.IntegrationTests.Tests.CreateChatCompletion",
        });
        response.Choices.ElementAt(0).Message.Content.Should().NotBeEmpty();

        Console.WriteLine(response.Choices.ElementAt(0).Message.Content);
    }
    
    [TestMethod]
    public async Task CreateChatCompletionAsStreamAsync()
    {
        var api = GetAuthorizedApi();
        var enumerable = api.CreateChatCompletionAsStreamAsync(new CreateChatCompletionRequest
        {
            Messages = new List<ChatCompletionRequestMessage>
            {
                "You are a helpful weather assistant.".AsSystemMessage(),
                "What's the weather like today?".AsUserMessage(),
            },
            Model = ModelIds.Gpt35Turbo_0613,
            User = "tryAGI.OpenAI.IntegrationTests.Tests.CreateChatCompletion",
        });
        await foreach (var response in enumerable)
        {
            Console.WriteLine(response.Choices.ElementAt(0).Delta.Content);
        }
    }
}
