
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The aggregated web search calls usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageWebSearchCallsResult
    {
        /// <summary>
        /// When grouped by `api_source`, `agents_api` identifies attributed Agents API activity and `unlabeled` includes all records without published source attribution, including historical and unknown origins. Unlabeled does not imply direct API usage. Without source grouping, this field is null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_source")]
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource? ApiSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UsageWebSearchCallsResultObjectJsonConverter))]
        public global::tryAGI.OpenAI.UsageWebSearchCallsResultObject Object { get; set; }

        /// <summary>
        /// The count of model requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_model_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumModelRequests { get; set; }

        /// <summary>
        /// The count of web search calls.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_level")]
        public string? ContextLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageWebSearchCallsResult" /> class.
        /// </summary>
        /// <param name="numModelRequests">
        /// The count of model requests.
        /// </param>
        /// <param name="numRequests">
        /// The count of web search calls.
        /// </param>
        /// <param name="apiSource">
        /// When grouped by `api_source`, `agents_api` identifies attributed Agents API activity and `unlabeled` includes all records without published source attribution, including historical and unknown origins. Unlabeled does not imply direct API usage. Without source grouping, this field is null.
        /// </param>
        /// <param name="object"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="model"></param>
        /// <param name="contextLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageWebSearchCallsResult(
            int numModelRequests,
            int numRequests,
            global::tryAGI.OpenAI.UsageWebSearchCallsResultApiSource? apiSource,
            global::tryAGI.OpenAI.UsageWebSearchCallsResultObject @object,
            string? projectId,
            string? userId,
            string? apiKeyId,
            string? model,
            string? contextLevel)
        {
            this.ApiSource = apiSource;
            this.Object = @object;
            this.NumModelRequests = numModelRequests;
            this.NumRequests = numRequests;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
            this.Model = model;
            this.ContextLevel = contextLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageWebSearchCallsResult" /> class.
        /// </summary>
        public UsageWebSearchCallsResult()
        {
        }

    }
}