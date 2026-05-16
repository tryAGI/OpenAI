
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The aggregated file search calls usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageFileSearchCallsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UsageFileSearchCallsResultObjectJsonConverter))]
        public global::tryAGI.OpenAI.UsageFileSearchCallsResultObject Object { get; set; }

        /// <summary>
        /// The count of file search calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumRequests { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_id")]
        public string? VectorStoreId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageFileSearchCallsResult" /> class.
        /// </summary>
        /// <param name="numRequests">
        /// The count of file search calls.
        /// </param>
        /// <param name="object"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="vectorStoreId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageFileSearchCallsResult(
            int numRequests,
            global::tryAGI.OpenAI.UsageFileSearchCallsResultObject @object,
            string? projectId,
            string? userId,
            string? apiKeyId,
            string? vectorStoreId)
        {
            this.Object = @object;
            this.NumRequests = numRequests;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
            this.VectorStoreId = vectorStoreId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageFileSearchCallsResult" /> class.
        /// </summary>
        public UsageFileSearchCallsResult()
        {
        }

    }
}