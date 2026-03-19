using Meai = Microsoft.Extensions.AI;
using Retry = Microsoft.VisualStudio.TestTools.UnitTesting.RetryAttribute;

namespace tryAGI.OpenAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_CanGetAsInterface()
    {
        using var client = GetAuthorizedApi();

        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        generator.Should().NotBeNull();
    }

    [TestMethod]
    [Retry(2)]
    public async Task EmbeddingGenerator_SingleInput()
    {
        using var client = GetAuthorizedApi();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var result = await generator.GenerateAsync(
            new List<string> { "Hello, world!" },
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "text-embedding-3-small",
            });

        result.Should().NotBeNull();
        result.Should().HaveCount(1);
        result[0].Vector.Length.Should().BeGreaterThan(0);
        Console.WriteLine($"Embedding dimension: {result[0].Vector.Length}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task EmbeddingGenerator_BatchInput()
    {
        using var client = GetAuthorizedApi();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var inputs = new List<string>
        {
            "Hello, world!",
            "How are you?",
            "Goodbye!",
        };

        var result = await generator.GenerateAsync(
            inputs,
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "text-embedding-3-small",
            });

        result.Should().NotBeNull();
        result.Should().HaveCount(3);

        foreach (var embedding in result)
        {
            embedding.Vector.Length.Should().BeGreaterThan(0);
        }

        Console.WriteLine($"Batch embedding dimension: {result[0].Vector.Length}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task EmbeddingGenerator_ReturnsUsage()
    {
        using var client = GetAuthorizedApi();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var result = await generator.GenerateAsync(
            new List<string> { "Test input for usage tracking" },
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "text-embedding-3-small",
            });

        result.Usage.Should().NotBeNull();
        result.Usage!.InputTokenCount.Should().BeGreaterThan(0);
        result.Usage.TotalTokenCount.Should().BeGreaterThan(0);
        Console.WriteLine($"Input tokens: {result.Usage.InputTokenCount}, Total: {result.Usage.TotalTokenCount}");
    }

    [TestMethod]
    [Retry(2)]
    public async Task EmbeddingGenerator_WithDimensions()
    {
        using var client = GetAuthorizedApi();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client;

        var result = await generator.GenerateAsync(
            new List<string> { "Test with custom dimensions" },
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "text-embedding-3-small",
                Dimensions = 256,
            });

        result.Should().NotBeNull();
        result[0].Vector.Length.Should().Be(256);
        Console.WriteLine($"Custom dimension embedding: {result[0].Vector.Length}");
    }
}
