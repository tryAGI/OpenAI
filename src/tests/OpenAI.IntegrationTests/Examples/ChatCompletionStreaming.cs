/*
order: 20
title: Chat Completion Streaming
slug: chat-completion-streaming

Stream a chat completion response token by token.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ChatCompletionStreaming()
    {
        using var client = GetAuthenticatedClient();

        var enumerable = client.Chat.CreateChatCompletionAsStreamAsync(
            new CreateChatCompletionRequest
            {
                CreateChatCompletionRequestVariant2 = new CreateChatCompletionRequestVariant2
                {
                    Messages = ["Generate five random words."],
                    Model = "gpt-4o-mini",
                }
            });

        await foreach (string response in enumerable)
        {
            Console.Write(response);
        }
    }
}
