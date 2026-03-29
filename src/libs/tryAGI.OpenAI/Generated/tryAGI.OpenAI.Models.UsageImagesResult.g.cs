
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The aggregated images usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageImagesResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UsageImagesResultObjectJsonConverter))]
        public global::tryAGI.OpenAI.UsageImagesResultObject Object { get; set; }

        /// <summary>
        /// The number of images processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Images { get; set; }

        /// <summary>
        /// The count of requests made to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_model_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumModelRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

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
        /// Initializes a new instance of the <see cref="UsageImagesResult" /> class.
        /// </summary>
        /// <param name="images">
        /// The number of images processed.
        /// </param>
        /// <param name="numModelRequests">
        /// The count of requests made to the model.
        /// </param>
        /// <param name="object"></param>
        /// <param name="source"></param>
        /// <param name="size"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageImagesResult(
            int images,
            int numModelRequests,
            global::tryAGI.OpenAI.UsageImagesResultObject @object,
            string? source,
            string? size,
            string? projectId,
            string? userId,
            string? apiKeyId,
            string? model)
        {
            this.Object = @object;
            this.Images = images;
            this.NumModelRequests = numModelRequests;
            this.Source = source;
            this.Size = size;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageImagesResult" /> class.
        /// </summary>
        public UsageImagesResult()
        {
        }
    }
}