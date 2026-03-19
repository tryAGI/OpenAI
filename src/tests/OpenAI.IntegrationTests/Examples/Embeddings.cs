/*
order: 50
title: Embeddings
slug: embeddings

Create a text embedding vector.
*/

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Embeddings()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Embeddings.CreateEmbeddingAsync(
            input: "Hello, world",
            model: CreateEmbeddingRequestModel.TextEmbedding3Small);

        foreach (var data in response.Data.ElementAt(0).Embedding1)
        {
            Console.WriteLine($"{data}");
        }
    }
}
