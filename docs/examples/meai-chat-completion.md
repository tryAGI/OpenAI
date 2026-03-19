# MEAI Chat Completion

Use the Microsoft.Extensions.AI IChatClient interface for chat completions.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

// using Meai = Microsoft.Extensions.AI;
Meai.IChatClient chatClient = client;

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "Say hello in exactly 3 words."),
};

var response = await chatClient.GetResponseAsync(
    messages,
    new Meai.ChatOptions { ModelId = "gpt-4o-mini" });

Console.WriteLine(response.Messages[0].Text);
```