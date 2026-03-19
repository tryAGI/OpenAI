/*
order: 100
title: MEAI Chat Completion
slug: meai-chat-completion

Use the Microsoft.Extensions.AI IChatClient interface for chat completions.
*/

using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiChatCompletion()
    {
        using var client = GetAuthenticatedClient();

        //// using Meai = Microsoft.Extensions.AI;
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Say hello in exactly 3 words."),
        };

        var response = await chatClient.GetResponseAsync(
            messages,
            new Meai.ChatOptions { ModelId = "gpt-4o-mini" });

        Console.WriteLine(response.Messages[0].Text);
    }
}
