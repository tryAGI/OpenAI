
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The aggregated embeddings usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageEmbeddingsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UsageEmbeddingsResultObjectJsonConverter))]
        public global::tryAGI.OpenAI.UsageEmbeddingsResultObject Object { get; set; }

        /// <summary>
        /// The aggregated number of input tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The count of requests made to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_model_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumModelRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageEmbeddingsResult" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The aggregated number of input tokens used.
        /// </param>
        /// <param name="numModelRequests">
        /// The count of requests made to the model.
        /// </param>
        /// <param name="object"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageEmbeddingsResult(
            int inputTokens,
            int numModelRequests,
            global::tryAGI.OpenAI.UsageEmbeddingsResultObject @object,
            string? projectId,
            string? userId,
            string? apiKeyId,
            string? model)
        {
            this.Object = @object;
            this.InputTokens = inputTokens;
            this.NumModelRequests = numModelRequests;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageEmbeddingsResult" /> class.
        /// </summary>
        public UsageEmbeddingsResult()
        {
        }
    }
}