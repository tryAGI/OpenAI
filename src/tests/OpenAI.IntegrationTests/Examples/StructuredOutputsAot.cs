/*
order: 46
title: Structured Outputs (AOT)
slug: structured-outputs-aot

Get structured JSON responses using a JsonTypeInfo for AOT/trimming compatibility.
*/

using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_StructuredOutputsAot()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Chat.CreateChatCompletionAsAsync(
            jsonTypeInfo: SourceGeneratedContext.Default.WordsResponse,
            messages: ["Generate five random words."],
            model: "gpt-4o-mini");

        Console.WriteLine("Words:");
        foreach (var word in response.Value1!.Words)
        {
            Console.WriteLine(word);
        }
    }
}
