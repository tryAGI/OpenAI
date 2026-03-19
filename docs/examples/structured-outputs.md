# Structured Outputs

Get structured JSON responses using a C# type as the schema.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Chat.CreateChatCompletionAsAsync<WordsResponse>(
    messages: ["Generate five random words as json."],
    model: "gpt-4o-mini");

Console.WriteLine("Words:");
foreach (var word in response.Value1!.Words)
{
    Console.WriteLine(word);
}
```