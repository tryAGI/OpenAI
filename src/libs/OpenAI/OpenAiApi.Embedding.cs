namespace tryAGI.OpenAI;

public partial class OpenAiApi
{
    /// <summary>
    /// User-friendly method for creating an embedding.
    /// Defaults to the <see cref="EmbeddingModelIds.Ada002"/> model.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="model"></param>
    /// <param name="user"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public async Task<ReadOnlyMemory<float>> CreateEmbeddingAsync(
        string input,
        string? model = null,
        string? user = null,
        CancellationToken cancellationToken = default)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));
        model ??= "text-embedding-ada-002";
        
        var response = await CreateEmbeddingAsync(new CreateEmbeddingRequest
        {
            Input = input,
            Model = model,
            User = user,
        }, cancellationToken).ConfigureAwait(false);
            
        return response.Data.ElementAt(0).Embedding
            .Select(static x => (float)x)
            .ToArray();
    }
}
