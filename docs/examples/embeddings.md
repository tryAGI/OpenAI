# Embeddings

Create a text embedding vector.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

var response = await client.Embeddings.CreateEmbeddingAsync(
    input: "Hello, world",
    model: CreateEmbeddingRequestModel.TextEmbedding3Small);

foreach (var data in response.Data.ElementAt(0).Embedding1)
{
    Console.WriteLine($"{data}");
}
```