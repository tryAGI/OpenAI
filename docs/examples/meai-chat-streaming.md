# MEAI Chat Streaming

Stream a chat completion using the Microsoft.Extensions.AI IChatClient interface.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

// using Meai = Microsoft.Extensions.AI;
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
```