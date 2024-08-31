namespace OpenAI.IntegrationTests.Examples;

public partial class Examples
{
    [Test]
    [Explicit]
    public async Task MultipleEmbeddings()
    {
        using var api = GetAuthenticatedClient();

        string category = "Luxury";
        string description = "Best hotel in town if you like luxury hotels. They have an amazing infinity pool, a spa,"
                             + " and a really helpful concierge. The location is perfect -- right downtown, close to all the tourist"
                             + " attractions. We highly recommend this hotel.";
        List<string> inputs = [category, description];

        CreateEmbeddingResponse response = await api.Embeddings.CreateEmbeddingAsync(
            input: inputs,
            model: CreateEmbeddingRequestModel.TextEmbedding3Small);

        foreach (Embedding embedding in response.Data)
        {
            IList<double> vector = embedding.Embedding1;

            Console.WriteLine($"Dimension: {vector.Count}");
            Console.WriteLine("Floats: ");
            for (int i = 0; i < vector.Count; i++)
            {
                Console.WriteLine($"  [{i,4}] = {vector[i]}");
            }

            Console.WriteLine();
        }
    }
}
