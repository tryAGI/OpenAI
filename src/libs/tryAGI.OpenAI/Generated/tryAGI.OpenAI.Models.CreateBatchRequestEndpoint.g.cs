
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The endpoint to be used for all requests in the batch. Currently `/v1/responses`, `/v1/chat/completions`, `/v1/embeddings`, `/v1/completions`, `/v1/moderations`, `/v1/images/generations`, `/v1/images/edits`, and `/v1/videos` are supported. Note that `/v1/embeddings` batches are also restricted to a maximum of 50,000 embedding inputs across all requests in the batch.
    /// </summary>
    public enum CreateBatchRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Dividev1DividechatDividecompletions,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Dividecompletions,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Divideembeddings,
        /// <summary>
        /// 
        /// </summary>
        Dividev1DivideimagesDivideedits,
        /// <summary>
        /// 
        /// </summary>
        Dividev1DivideimagesDividegenerations,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Dividemoderations,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Divideresponses,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Dividevideos,
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
                CreateBatchRequestEndpoint.Dividev1DividechatDividecompletions => "/v1/chat/completions",
                CreateBatchRequestEndpoint.Dividev1Dividecompletions => "/v1/completions",
                CreateBatchRequestEndpoint.Dividev1Divideembeddings => "/v1/embeddings",
                CreateBatchRequestEndpoint.Dividev1DivideimagesDivideedits => "/v1/images/edits",
                CreateBatchRequestEndpoint.Dividev1DivideimagesDividegenerations => "/v1/images/generations",
                CreateBatchRequestEndpoint.Dividev1Dividemoderations => "/v1/moderations",
                CreateBatchRequestEndpoint.Dividev1Divideresponses => "/v1/responses",
                CreateBatchRequestEndpoint.Dividev1Dividevideos => "/v1/videos",
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
                "/v1/chat/completions" => CreateBatchRequestEndpoint.Dividev1DividechatDividecompletions,
                "/v1/completions" => CreateBatchRequestEndpoint.Dividev1Dividecompletions,
                "/v1/embeddings" => CreateBatchRequestEndpoint.Dividev1Divideembeddings,
                "/v1/images/edits" => CreateBatchRequestEndpoint.Dividev1DivideimagesDivideedits,
                "/v1/images/generations" => CreateBatchRequestEndpoint.Dividev1DivideimagesDividegenerations,
                "/v1/moderations" => CreateBatchRequestEndpoint.Dividev1Dividemoderations,
                "/v1/responses" => CreateBatchRequestEndpoint.Dividev1Divideresponses,
                "/v1/videos" => CreateBatchRequestEndpoint.Dividev1Dividevideos,
                _ => null,
            };
        }
    }
}