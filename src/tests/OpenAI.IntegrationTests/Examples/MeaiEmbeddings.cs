/*
order: 130
title: MEAI Embeddings
slug: meai-embeddings

Generate embeddings using the Microsoft.Extensions.AI IEmbeddingGenerator interface.
*/

using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiEmbeddings()
    {
        using var client = GetAuthenticatedClient();

        //// using Meai = Microsoft.Extensions.AI;
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var result = await generator.GenerateAsync(
            new List<string> { "Hello, world!" },
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "text-embedding-3-small",
            });

        Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
    }
}
