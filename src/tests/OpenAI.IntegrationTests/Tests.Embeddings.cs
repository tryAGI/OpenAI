namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateEmbedding()
    {
        var api = GetAuthorizedApi();
        var response = await api.Embeddings.CreateEmbeddingAsync(new CreateEmbeddingRequest
        {
            Input = "Hello, world",
            Model = CreateEmbeddingRequestModel.TextEmbedding3Small,
            EncodingFormat = CreateEmbeddingRequestEncodingFormat.Float,
            User = "tryAGI.OpenAI.IntegrationTests.Tests.CreateEmbedding",
        });
        response.Data.ElementAt(0).GetFloatVector().Should().NotBeEmpty();

        foreach (var data in response.Data.ElementAt(0).GetFloatVector())
        {
            Console.WriteLine($"{data}");
        }
    }

    [TestMethod]
    public void EmbeddingFloatVector()
    {
        var embedding = System.Text.Json.JsonSerializer.Deserialize<Embedding>(
            """{"index":0,"embedding":[0.25,0.5],"object":"embedding"}""",
            SourceGenerationContext.Default.Options)!;

        embedding.GetFloatVector().Should().Equal(0.25f, 0.5f);
    }
}
