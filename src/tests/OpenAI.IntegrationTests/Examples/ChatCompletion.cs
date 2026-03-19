/*
order: 10
title: Chat Completion
slug: chat-completion

Send a simple chat completion request.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ChatCompletion()
    {
        using var client = GetAuthenticatedClient();

        string response = await client.Chat.CreateChatCompletionAsync(
            new CreateChatCompletionRequest
            {
                Value2 = new CreateChatCompletionRequestVariant2
                {
                    Messages = ["Generate five random words."],
                    Model = "gpt-4o-mini",
                }
            });

        Console.WriteLine(response);
    }
}
