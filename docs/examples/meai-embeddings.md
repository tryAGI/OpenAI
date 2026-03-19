# MEAI Embeddings

Generate embeddings using the Microsoft.Extensions.AI IEmbeddingGenerator interface.

This example assumes `using tryAGI.OpenAI;` is in scope and `apiKey` contains your tryAGI.OpenAI API key.

```csharp
using var client = new OpenAiClient(apiKey);

// using Meai = Microsoft.Extensions.AI;
Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

var result = await generator.GenerateAsync(
    new List<string> { "Hello, world!" },
    new Meai.EmbeddingGenerationOptions
    {
        ModelId = "text-embedding-3-small",
    });

Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
```