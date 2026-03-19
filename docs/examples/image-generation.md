# Image Generation

Generate an image from a text prompt.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Images.CreateImageAsync(
    prompt: "a white siamese cat",
    model: CreateImageRequestModel.GptImage1Mini,
    n: 1,
    quality: CreateImageRequestQuality.Low,
    size: CreateImageRequestSize.x1024x1024,
    outputFormat: CreateImageRequestOutputFormat.Png);

var base64 = response.Data?.ElementAt(0).B64Json;

Console.WriteLine($"Generated image ({base64?.Length} base64 chars)");
```