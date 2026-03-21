using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI;

public sealed partial class OpenAiClient : Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>
{
    object? Meai.IEmbeddingGenerator.GetService(
        Type serviceType, object? serviceKey)
    {
        if (serviceKey is not null)
        {
            return null;
        }

        if (serviceType == typeof(Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>) ||
            serviceType.IsInstanceOfType(this))
        {
            return this;
        }

        return null;
    }

    async Task<Meai.GeneratedEmbeddings<Meai.Embedding<float>>>
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>.GenerateAsync(
            IEnumerable<string> values,
            Meai.EmbeddingGenerationOptions? options,
            CancellationToken cancellationToken)
    {
        var inputList = values as IList<string> ?? values.ToList();

        var modelId = options?.ModelId ?? "text-embedding-3-small";
        var knownModel = CreateEmbeddingRequestModelExtensions.ToEnum(modelId);

        var request = new CreateEmbeddingRequest
        {
            Input = inputList.Count == 1
                ? inputList[0]
                : new OneOf<string, IList<string>, IList<int>, IList<IList<int>>>(
                    (IList<string>)inputList),
            Model = modelId,
        };

        if (knownModel is not null)
        {
            request.Model = knownModel.Value;
        }

        if (options?.Dimensions is { } dimensions)
        {
            request.Dimensions = dimensions;
        }

        var response = await Embeddings.CreateEmbeddingsAsync(
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var embeddings = new Meai.GeneratedEmbeddings<Meai.Embedding<float>>(
            response.Data.Select(e => new Meai.Embedding<float>(e.Embedding1.ToArray())
            {
                ModelId = response.Model,
            }).ToList());

        if (response.Usage is { } usage)
        {
            embeddings.Usage = new Meai.UsageDetails
            {
                InputTokenCount = usage.PromptTokens,
                TotalTokenCount = usage.TotalTokens,
            };
        }

        return embeddings;
    }
}
