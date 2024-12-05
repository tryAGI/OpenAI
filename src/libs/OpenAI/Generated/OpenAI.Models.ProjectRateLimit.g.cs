
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Represents a project rate limit config.
    /// </summary>
    public sealed partial class ProjectRateLimit
    {
        /// <summary>
        /// The object type, which is always `project.rate_limit`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.ProjectRateLimitObjectJsonConverter))]
        public global::OpenAI.ProjectRateLimitObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The model this rate limit applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The maximum requests per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_1_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxRequestsPer1Minute { get; set; }

        /// <summary>
        /// The maximum tokens per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens_per_1_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokensPer1Minute { get; set; }

        /// <summary>
        /// The maximum images per minute. Only present for relevant models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_images_per_1_minute")]
        public int? MaxImagesPer1Minute { get; set; }

        /// <summary>
        /// The maximum audio megabytes per minute. Only present for relevant models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_audio_megabytes_per_1_minute")]
        public int? MaxAudioMegabytesPer1Minute { get; set; }

        /// <summary>
        /// The maximum requests per day. Only present for relevant models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_1_day")]
        public int? MaxRequestsPer1Day { get; set; }

        /// <summary>
        /// The maximum batch input tokens per day. Only present for relevant models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_1_day_max_input_tokens")]
        public int? Batch1DayMaxInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRateLimit" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `project.rate_limit`
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="model">
        /// The model this rate limit applies to.
        /// </param>
        /// <param name="maxRequestsPer1Minute">
        /// The maximum requests per minute.
        /// </param>
        /// <param name="maxTokensPer1Minute">
        /// The maximum tokens per minute.
        /// </param>
        /// <param name="maxImagesPer1Minute">
        /// The maximum images per minute. Only present for relevant models.
        /// </param>
        /// <param name="maxAudioMegabytesPer1Minute">
        /// The maximum audio megabytes per minute. Only present for relevant models.
        /// </param>
        /// <param name="maxRequestsPer1Day">
        /// The maximum requests per day. Only present for relevant models.
        /// </param>
        /// <param name="batch1DayMaxInputTokens">
        /// The maximum batch input tokens per day. Only present for relevant models.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectRateLimit(
            string id,
            string model,
            int maxRequestsPer1Minute,
            int maxTokensPer1Minute,
            global::OpenAI.ProjectRateLimitObject @object,
            int? maxImagesPer1Minute,
            int? maxAudioMegabytesPer1Minute,
            int? maxRequestsPer1Day,
            int? batch1DayMaxInputTokens)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxRequestsPer1Minute = maxRequestsPer1Minute;
            this.MaxTokensPer1Minute = maxTokensPer1Minute;
            this.Object = @object;
            this.MaxImagesPer1Minute = maxImagesPer1Minute;
            this.MaxAudioMegabytesPer1Minute = maxAudioMegabytesPer1Minute;
            this.MaxRequestsPer1Day = maxRequestsPer1Day;
            this.Batch1DayMaxInputTokens = batch1DayMaxInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRateLimit" /> class.
        /// </summary>
        public ProjectRateLimit()
        {
        }
    }
}