# Moderation

Check text for policy violations using the moderation endpoint.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Moderations.CreateModerationAsync(
    input: "Hello, world",
    model: CreateModerationRequestModel.OmniModerationLatest);

Console.WriteLine($"Flagged: {response.Results.First().Flagged}");
```