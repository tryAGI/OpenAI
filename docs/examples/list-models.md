# List Models

List all available models.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

var models = await client.Models.ListModelsAsync();

foreach (var model in models.Data)
{
    Console.WriteLine(model.Id);
}
```