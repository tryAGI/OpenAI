/*
order: 30
title: Chat With Vision
slug: chat-with-vision

Send an image to the model for analysis.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ChatWithVision()
    {
        using var client = GetAuthenticatedClient();

        CreateChatCompletionResponse response = await client.Chat.CreateChatCompletionAsync(
            new CreateChatCompletionRequest
            {
                Value2 = new CreateChatCompletionRequestVariant2
                {
                    Messages = [
                        "Please describe the following image.",
                        H.Resources.images_dog_and_cat_png.AsBytes().AsUserMessage(mimeType: "image/png"),
                    ],
                    Model = "gpt-4o-mini",
                }
            });

        Console.WriteLine(response.Choices[0].Message.Content);
    }
}
