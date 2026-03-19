# JSON Response Format

Request a response in JSON format.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

string response = await client.Chat.CreateChatCompletionAsync(
    new CreateChatCompletionRequest
    {
        Value2 = new CreateChatCompletionRequestVariant2
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
```