using tryAGI.OpenAI;

namespace H.Ipc.Generator.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Streaming()
    {
        var messages = new List<ChatCompletionRequestMessage>
        {
            "You are a helpful weather assistant.".AsSystemMessage(),
            "What's the weather like today?".AsUserMessage(),
        };
        
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY is not set.");
        using var httpClient = new HttpClient();
        var api = new OpenAiApi(apiKey, httpClient);
        var result = api.CreateChatCompletionAsStreamAsync(new CreateChatCompletionRequest
        {
            Messages = messages,
            Model = ModelIds.Gpt35Turbo_0613,
        });
        await foreach (var response in result)
        {
            var delta = response.GetFirstChoiceDelta();
            if (delta.Role != null)
            {
                Console.WriteLine($"Role: {delta.Role}");
            }
            if (delta.Content != null)
            {
                Console.WriteLine($"Content: {delta.Content}");
            }
            if (delta.Function_call != null)
            {
                Console.WriteLine($"Function_call: {delta.Function_call.Name} {delta.Function_call.Arguments}");
            }
        }
    }
}