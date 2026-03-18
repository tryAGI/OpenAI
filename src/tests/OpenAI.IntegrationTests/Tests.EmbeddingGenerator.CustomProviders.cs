using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI.IntegrationTests;

/// <summary>
/// Tests MEAI IEmbeddingGenerator interface across CustomProviders that support embeddings.
/// Each provider requires its own API key environment variable.
/// </summary>
public partial class Tests
{
    private async Task EmbeddingGenerator_CustomProvider_GenerateAsync(
        CustomProvider provider, string embeddingModel)
    {
        var (api, _) = GetAuthorizedChatApi(provider);
        using var _ = api;
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = api;

        var result = await generator.GenerateAsync(
            ["Hello, world!"],
            new Meai.EmbeddingGenerationOptions { ModelId = embeddingModel });

        result.Should().NotBeNull();
        result.Should().HaveCount(1);
        result[0].Vector.Length.Should().BeGreaterThan(0);
        Console.WriteLine($"[{provider}] Embedding dimensions: {result[0].Vector.Length}");
    }

    private async Task EmbeddingGenerator_CustomProvider_BatchAsync(
        CustomProvider provider, string embeddingModel)
    {
        var (api, _) = GetAuthorizedChatApi(provider);
        using var _ = api;
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = api;

        var result = await generator.GenerateAsync(
            ["First sentence.", "Second sentence.", "Third sentence."],
            new Meai.EmbeddingGenerationOptions { ModelId = embeddingModel });

        result.Should().HaveCount(3);
        foreach (var embedding in result)
        {
            embedding.Vector.Length.Should().BeGreaterThan(0);
        }
        Console.WriteLine($"[{provider}] Batch: {result.Count} embeddings, {result[0].Vector.Length} dimensions");
    }

    // --- DeepInfra ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_DeepInfra_Generate() =>
        EmbeddingGenerator_CustomProvider_GenerateAsync(
            CustomProvider.DeepInfra, "BAAI/bge-en-icl");

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_DeepInfra_Batch() =>
        EmbeddingGenerator_CustomProvider_BatchAsync(
            CustomProvider.DeepInfra, "BAAI/bge-en-icl");

    // --- Together ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Together_Generate() =>
        EmbeddingGenerator_CustomProvider_GenerateAsync(
            CustomProvider.Together, "BAAI/bge-large-en-v1.5");

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Together_Batch() =>
        EmbeddingGenerator_CustomProvider_BatchAsync(
            CustomProvider.Together, "BAAI/bge-large-en-v1.5");

    // --- Mistral ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Mistral_Generate() =>
        EmbeddingGenerator_CustomProvider_GenerateAsync(
            CustomProvider.Mistral, "mistral-embed");

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Mistral_Batch() =>
        EmbeddingGenerator_CustomProvider_BatchAsync(
            CustomProvider.Mistral, "mistral-embed");

    // --- Cohere ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Cohere_Generate() =>
        EmbeddingGenerator_CustomProvider_GenerateAsync(
            CustomProvider.Cohere, "embed-english-v3.0");

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Cohere_Batch() =>
        EmbeddingGenerator_CustomProvider_BatchAsync(
            CustomProvider.Cohere, "embed-english-v3.0");

    // --- Fireworks ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Fireworks_Generate() =>
        EmbeddingGenerator_CustomProvider_GenerateAsync(
            CustomProvider.Fireworks, "nomic-ai/nomic-embed-text-v1.5");

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Fireworks_Batch() =>
        EmbeddingGenerator_CustomProvider_BatchAsync(
            CustomProvider.Fireworks, "nomic-ai/nomic-embed-text-v1.5");

    // --- Nebius ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Nebius_Generate() =>
        EmbeddingGenerator_CustomProvider_GenerateAsync(
            CustomProvider.Nebius, "BAAI/bge-en-icl");

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_Nebius_Batch() =>
        EmbeddingGenerator_CustomProvider_BatchAsync(
            CustomProvider.Nebius, "BAAI/bge-en-icl");

    // --- Azure ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public async Task EmbeddingGenerator_Azure_Generate()
    {
        var (api, _) = GetAuthorizedChatApi(CustomProvider.Azure);
        using var _ = api;
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = api;

        var embeddingModel = Environment.GetEnvironmentVariable("AZURE_OPENAI_EMBEDDING_MODEL")
            ?? "text-embedding-3-small";

        var result = await generator.GenerateAsync(
            ["Hello, world!"],
            new Meai.EmbeddingGenerationOptions { ModelId = embeddingModel });

        result.Should().NotBeNull();
        result.Should().HaveCount(1);
        result[0].Vector.Length.Should().BeGreaterThan(0);
        Console.WriteLine($"[Azure] Embedding dimensions: {result[0].Vector.Length}");
    }

    // --- GitHub Models ---

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_GitHub_Generate() =>
        EmbeddingGenerator_CustomProvider_GenerateAsync(
            CustomProvider.GitHub, "text-embedding-3-small");

    [TestMethod]
    [Microsoft.VisualStudio.TestTools.UnitTesting.Retry(2)]
    public Task EmbeddingGenerator_GitHub_Batch() =>
        EmbeddingGenerator_CustomProvider_BatchAsync(
            CustomProvider.GitHub, "text-embedding-3-small");
}
