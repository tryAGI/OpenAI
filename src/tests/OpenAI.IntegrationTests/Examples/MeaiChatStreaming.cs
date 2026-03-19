/*
order: 110
title: MEAI Chat Streaming
slug: meai-chat-streaming

Stream a chat completion using the Microsoft.Extensions.AI IChatClient interface.
*/

using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiChatStreaming()
    {
        using var client = GetAuthenticatedClient();

        //// using Meai = Microsoft.Extensions.AI;
        Meai.IChatClient chatClient = client;

        var messages = new List<Meai.ChatMessage>
        {
            new(Meai.ChatRole.User, "Count from 1 to 5."),
        };

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            messages,
            new Meai.ChatOptions { ModelId = "gpt-4o-mini" }))
        {
            var text = string.Concat(update.Contents.OfType<Meai.TextContent>().Select(c => c.Text));
            if (!string.IsNullOrEmpty(text))
            {
                Console.Write(text);
            }
        }
    }
}
