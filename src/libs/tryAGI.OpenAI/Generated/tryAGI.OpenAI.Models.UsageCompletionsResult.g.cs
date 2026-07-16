
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The aggregated completions usage details of the specific time bucket.
    /// </summary>
    public sealed partial class UsageCompletionsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UsageCompletionsResultObjectJsonConverter))]
        public global::tryAGI.OpenAI.UsageCompletionsResultObject Object { get; set; }

        /// <summary>
        /// The aggregated number of input tokens used, including cached and cache-write tokens. This includes text, audio, and image tokens. For customers subscribed to Scale Tier, this includes Scale Tier tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The aggregated number of cached input tokens used across text, audio, and image inputs. For customers subscribed to Scale Tier, this includes Scale Tier tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_tokens")]
        public int? InputCachedTokens { get; set; }

        /// <summary>
        /// The aggregated number of input tokens written to the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write_tokens")]
        public int? InputCacheWriteTokens { get; set; }

        /// <summary>
        /// The aggregated number of uncached input tokens used across text, audio, and image inputs, excluding cache-write tokens.
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
        /// The aggregated number of uncached text input tokens used, excluding cache-write tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text_tokens")]
        public int? InputTextTokens { get; set; }

        /// <summary>
        /// The aggregated number of text output tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text_tokens")]
        public int? OutputTextTokens { get; set; }

        /// <summary>
        /// The aggregated number of cached text input tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_text_tokens")]
        public int? InputCachedTextTokens { get; set; }

        /// <summary>
        /// The aggregated number of uncached audio input tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_tokens")]
        public int? InputAudioTokens { get; set; }

        /// <summary>
        /// The aggregated number of cached audio input tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_audio_tokens")]
        public int? InputCachedAudioTokens { get; set; }

        /// <summary>
        /// The aggregated number of audio output tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_tokens")]
        public int? OutputAudioTokens { get; set; }

        /// <summary>
        /// The aggregated number of uncached image input tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image_tokens")]
        public int? InputImageTokens { get; set; }

        /// <summary>
        /// The aggregated number of cached image input tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cached_image_tokens")]
        public int? InputCachedImageTokens { get; set; }

        /// <summary>
        /// The aggregated number of image output tokens used.
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
        /// Initializes a new instance of the <see cref="UsageCompletionsResult" /> class.
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
        /// <param name="object"></param>
        /// <param name="inputCachedTokens">
        /// The aggregated number of cached input tokens used across text, audio, and image inputs. For customers subscribed to Scale Tier, this includes Scale Tier tokens.
        /// </param>
        /// <param name="inputCacheWriteTokens">
        /// The aggregated number of input tokens written to the cache.
        /// </param>
        /// <param name="inputUncachedTokens">
        /// The aggregated number of uncached input tokens used across text, audio, and image inputs, excluding cache-write tokens.
        /// </param>
        /// <param name="inputTextTokens">
        /// The aggregated number of uncached text input tokens used, excluding cache-write tokens.
        /// </param>
        /// <param name="outputTextTokens">
        /// The aggregated number of text output tokens used.
        /// </param>
        /// <param name="inputCachedTextTokens">
        /// The aggregated number of cached text input tokens used.
        /// </param>
        /// <param name="inputAudioTokens">
        /// The aggregated number of uncached audio input tokens used.
        /// </param>
        /// <param name="inputCachedAudioTokens">
        /// The aggregated number of cached audio input tokens used.
        /// </param>
        /// <param name="outputAudioTokens">
        /// The aggregated number of audio output tokens used.
        /// </param>
        /// <param name="inputImageTokens">
        /// The aggregated number of uncached image input tokens used.
        /// </param>
        /// <param name="inputCachedImageTokens">
        /// The aggregated number of cached image input tokens used.
        /// </param>
        /// <param name="outputImageTokens">
        /// The aggregated number of image output tokens used.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="model"></param>
        /// <param name="batch"></param>
        /// <param name="serviceTier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageCompletionsResult(
            int inputTokens,
            int outputTokens,
            int numModelRequests,
            global::tryAGI.OpenAI.UsageCompletionsResultObject @object,
            int? inputCachedTokens,
            int? inputCacheWriteTokens,
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
            string? serviceTier)
        {
            this.Object = @object;
            this.InputTokens = inputTokens;
            this.InputCachedTokens = inputCachedTokens;
            this.InputCacheWriteTokens = inputCacheWriteTokens;
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
        /// Initializes a new instance of the <see cref="UsageCompletionsResult" /> class.
        /// </summary>
        public UsageCompletionsResult()
        {
        }

    }
}