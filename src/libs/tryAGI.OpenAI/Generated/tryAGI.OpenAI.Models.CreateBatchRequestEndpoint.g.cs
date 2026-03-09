
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The endpoint to be used for all requests in the batch. Currently `/v1/responses`, `/v1/chat/completions`, `/v1/embeddings`, `/v1/completions`, `/v1/moderations`, `/v1/images/generations`, and `/v1/images/edits` are supported. Note that `/v1/embeddings` batches are also restricted to a maximum of 50,000 embedding inputs across all requests in the batch.
    /// </summary>
    public enum CreateBatchRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        V1Responses,
        /// <summary>
        /// 
        /// </summary>
        V1ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        V1Embeddings,
        /// <summary>
        /// 
        /// </summary>
        V1Completions,
        /// <summary>
        /// 
        /// </summary>
        V1Moderations,
        /// <summary>
        /// 
        /// </summary>
        V1ImagesGenerations,
        /// <summary>
        /// 
        /// </summary>
        V1ImagesEdits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchRequestEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchRequestEndpoint value)
        {
            return value switch
            {
                CreateBatchRequestEndpoint.V1Responses => "/v1/responses",
                CreateBatchRequestEndpoint.V1ChatCompletions => "/v1/chat/completions",
                CreateBatchRequestEndpoint.V1Embeddings => "/v1/embeddings",
                CreateBatchRequestEndpoint.V1Completions => "/v1/completions",
                CreateBatchRequestEndpoint.V1Moderations => "/v1/moderations",
                CreateBatchRequestEndpoint.V1ImagesGenerations => "/v1/images/generations",
                CreateBatchRequestEndpoint.V1ImagesEdits => "/v1/images/edits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchRequestEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/responses" => CreateBatchRequestEndpoint.V1Responses,
                "/v1/chat/completions" => CreateBatchRequestEndpoint.V1ChatCompletions,
                "/v1/embeddings" => CreateBatchRequestEndpoint.V1Embeddings,
                "/v1/completions" => CreateBatchRequestEndpoint.V1Completions,
                "/v1/moderations" => CreateBatchRequestEndpoint.V1Moderations,
                "/v1/images/generations" => CreateBatchRequestEndpoint.V1ImagesGenerations,
                "/v1/images/edits" => CreateBatchRequestEndpoint.V1ImagesEdits,
                _ => null,
            };
        }
    }
}