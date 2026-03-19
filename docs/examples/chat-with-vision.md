# Chat With Vision

Send an image to the model for analysis.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

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
```