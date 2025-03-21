namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task ChatWithVision()
    {
        using var api = GetAuthenticatedClient();
        
        CreateChatCompletionResponse response = await api.Chat.CreateChatCompletionAsync(
            messages: [
                "Please describe the following image.",
                H.Resources.images_dog_and_cat_png.AsBytes().AsUserMessage(mimeType: "image/png"),
            ],
            model: ModelIdsEnum.Gpt4o);

        Console.WriteLine("[ASSISTANT]:");
        Console.WriteLine($"{response.Choices[0].Message.Content}");
    }
}
