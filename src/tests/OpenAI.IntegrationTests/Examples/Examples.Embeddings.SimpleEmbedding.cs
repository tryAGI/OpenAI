namespace tryAGI.OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task SimpleEmbedding()
    {
        using var api = GetAuthenticatedClient();

        CreateEmbeddingResponse embedding = await api.Embeddings.CreateEmbeddingAsync(
            input: "Best hotel in town if you like luxury hotels. They have an amazing infinity pool, a spa,"
                   + " and a really helpful concierge. The location is perfect -- right downtown, close to all the tourist"
                   + " attractions. We highly recommend this hotel.",
            model: CreateEmbeddingRequestModel.TextEmbedding3Small);
        IList<double> vector = embedding.Data[0].Embedding1;

        Console.WriteLine($"Dimension: {vector.Count}");
        Console.WriteLine("Floats: ");
        for (int i = 0; i < vector.Count; i++)
        {
            Console.WriteLine($"  [{i,4}] = {vector[i]}");
        }
    }
}
