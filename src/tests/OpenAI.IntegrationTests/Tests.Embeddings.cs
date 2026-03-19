namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateEmbedding()
    {
        var api = GetAuthorizedApi();
        var response = await api.Embeddings.CreateEmbeddingAsync(
            input: "Hello, world",
            model: CreateEmbeddingRequestModel.TextEmbedding3Small,
            user: "tryAGI.OpenAI.IntegrationTests.Tests.CreateEmbedding");
        response.Data.ElementAt(0).Embedding1.Should().NotBeEmpty();

        foreach (var data in response.Data.ElementAt(0).Embedding1)
        {
            Console.WriteLine($"{data}");
        }
    }
}
