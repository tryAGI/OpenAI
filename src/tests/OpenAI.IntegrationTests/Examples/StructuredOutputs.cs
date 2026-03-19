/*
order: 45
title: Structured Outputs
slug: structured-outputs

Get structured JSON responses using a C# type as the schema.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StructuredOutputs()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Chat.CreateChatCompletionAsAsync<WordsResponse>(
            messages: ["Generate five random words as json."],
            model: "gpt-4o-mini");

        Console.WriteLine("Words:");
        foreach (var word in response.Value1!.Words)
        {
            Console.WriteLine(word);
        }
    }
}
