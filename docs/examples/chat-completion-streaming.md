# Chat Completion Streaming

Stream a chat completion response token by token.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

var enumerable = client.Chat.CreateChatCompletionAsStreamAsync(
    new CreateChatCompletionRequest
    {
        Value2 = new CreateChatCompletionRequestVariant2
        {
            Messages = ["Generate five random words."],
            Model = "gpt-4o-mini",
        }
    });

await foreach (string response in enumerable)
{
    Console.Write(response);
}
```