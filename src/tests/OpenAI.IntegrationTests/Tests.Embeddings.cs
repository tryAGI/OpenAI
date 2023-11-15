using OpenAI.Embeddings;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateEmbedding()
    {
        var api = GetAuthorizedApi();
        var response = await api.EmbeddingsEndpoint.CreateEmbeddingAsync(new EmbeddingsRequest(
            input: "Hello, world",
            model: EmbeddingModelIds.Ada002,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateEmbedding"));
        response.Data.ElementAt(0).Embedding.Should().NotBeEmpty();

        foreach (var data in response.Data.ElementAt(0).Embedding)
        {
            Console.WriteLine($"{data}");
        }
    }
}
