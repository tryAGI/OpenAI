
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The aggregated Decisions API usage details of the specific time bucket.
    /// </summary>
    public sealed partial class DecisionsUsageResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_source")]
        public global::tryAGI.OpenAI.DecisionsUsageApiSource? ApiSource { get; set; }

        /// <summary>
        /// Default Value: organization.usage.decisions.result
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionsUsageResultObject.OrganizationUsageDecisionsResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionsUsageResultObjectJsonConverter))]
        public global::tryAGI.OpenAI.DecisionsUsageResultObject Object { get; set; } = global::tryAGI.OpenAI.DecisionsUsageResultObject.OrganizationUsageDecisionsResult;

        /// <summary>
        /// The aggregated number of input tokens used, including cached and cache-write tokens. This includes text, audio, and image tokens. For customers subscribed to Scale Tier, this includes Scale Tier tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_tokens")]
        public int? InputCachedTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write_tokens")]
        public int? InputCacheWriteTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write_12h_tokens")]
        public int? InputCacheWrite12hTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_uncached_tokens")]
        public int? InputUncachedTokens { get; set; }

        /// <summary>
        /// The aggregated number of output tokens used across text, audio, and image outputs. For customers subscribed to Scale Tier, this includes Scale Tier tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text_tokens")]
        public int? InputTextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text_tokens")]
        public int? OutputTextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_text_tokens")]
        public int? InputCachedTextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_tokens")]
        public int? InputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_audio_tokens")]
        public int? InputCachedAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_tokens")]
        public int? OutputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_tokens")]
        public int? InputImageTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_image_tokens")]
        public int? InputCachedImageTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_image_tokens")]
        public int? OutputImageTokens { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public bool? Batch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsUsageResult" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The aggregated number of input tokens used, including cached and cache-write tokens. This includes text, audio, and image tokens. For customers subscribed to Scale Tier, this includes Scale Tier tokens.
        /// </param>
        /// <param name="outputTokens">
        /// The aggregated number of output tokens used across text, audio, and image outputs. For customers subscribed to Scale Tier, this includes Scale Tier tokens.
        /// </param>
        /// <param name="numModelRequests">
        /// The count of requests made to the model.
        /// </param>
        /// <param name="apiSource"></param>
        /// <param name="inputCachedTokens"></param>
        /// <param name="inputCacheWriteTokens"></param>
        /// <param name="inputCacheWrite12hTokens"></param>
        /// <param name="inputUncachedTokens"></param>
        /// <param name="inputTextTokens"></param>
        /// <param name="outputTextTokens"></param>
        /// <param name="inputCachedTextTokens"></param>
        /// <param name="inputAudioTokens"></param>
        /// <param name="inputCachedAudioTokens"></param>
        /// <param name="outputAudioTokens"></param>
        /// <param name="inputImageTokens"></param>
        /// <param name="inputCachedImageTokens"></param>
        /// <param name="outputImageTokens"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="model"></param>
        /// <param name="batch"></param>
        /// <param name="serviceTier"></param>
        /// <param name="object">
        /// Default Value: organization.usage.decisions.result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsUsageResult(
            int inputTokens,
            int outputTokens,
            int numModelRequests,
            global::tryAGI.OpenAI.DecisionsUsageApiSource? apiSource,
            int? inputCachedTokens,
            int? inputCacheWriteTokens,
            int? inputCacheWrite12hTokens,
            int? inputUncachedTokens,
            int? inputTextTokens,
            int? outputTextTokens,
            int? inputCachedTextTokens,
            int? inputAudioTokens,
            int? inputCachedAudioTokens,
            int? outputAudioTokens,
            int? inputImageTokens,
            int? inputCachedImageTokens,
            int? outputImageTokens,
            string? projectId,
            string? userId,
            string? apiKeyId,
            string? model,
            bool? batch,
            string? serviceTier,
            global::tryAGI.OpenAI.DecisionsUsageResultObject @object = global::tryAGI.OpenAI.DecisionsUsageResultObject.OrganizationUsageDecisionsResult)
        {
            this.ApiSource = apiSource;
            this.Object = @object;
            this.InputTokens = inputTokens;
            this.InputCachedTokens = inputCachedTokens;
            this.InputCacheWriteTokens = inputCacheWriteTokens;
            this.InputCacheWrite12hTokens = inputCacheWrite12hTokens;
            this.InputUncachedTokens = inputUncachedTokens;
            this.OutputTokens = outputTokens;
            this.InputTextTokens = inputTextTokens;
            this.OutputTextTokens = outputTextTokens;
            this.InputCachedTextTokens = inputCachedTextTokens;
            this.InputAudioTokens = inputAudioTokens;
            this.InputCachedAudioTokens = inputCachedAudioTokens;
            this.OutputAudioTokens = outputAudioTokens;
            this.InputImageTokens = inputImageTokens;
            this.InputCachedImageTokens = inputCachedImageTokens;
            this.OutputImageTokens = outputImageTokens;
            this.NumModelRequests = numModelRequests;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ApiKeyId = apiKeyId;
            this.Model = model;
            this.Batch = batch;
            this.ServiceTier = serviceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsUsageResult" /> class.
        /// </summary>
        public DecisionsUsageResult()
        {
        }

    }
}