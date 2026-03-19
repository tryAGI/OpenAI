# Chat Completion

Send a simple chat completion request.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

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
```