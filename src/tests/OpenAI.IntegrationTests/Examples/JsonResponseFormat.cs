/*
order: 40
title: JSON Response Format
slug: json-response-format

Request a response in JSON format.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_JsonResponseFormat()
    {
        using var client = GetAuthenticatedClient();

        string response = await client.Chat.CreateChatCompletionAsync(
            new CreateChatCompletionRequest
            {
                CreateChatCompletionRequestVariant2 = new CreateChatCompletionRequestVariant2
                {
                    Messages = ["Generate five random words as json."],
                    Model = "gpt-4o-mini",
                    ResponseFormat = new ResponseFormatJsonObject
                    {
                        Type = ResponseFormatJsonObjectType.JsonObject,
                    },
                }
            });

        Console.WriteLine(response);
    }
}
