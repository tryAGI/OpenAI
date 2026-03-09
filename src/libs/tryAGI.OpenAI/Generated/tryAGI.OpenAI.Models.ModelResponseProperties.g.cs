
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelResponseProperties
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// This field is being replaced by `safety_identifier` and `prompt_cache_key`. Use `prompt_cache_key` instead to maintain caching optimizations.<br/>
        /// A stable identifier for your end-users.<br/>
        /// Used to boost cache hit rates by better bucketing similar requests and  to help OpenAI detect and prevent abuse. [Learn more](/docs/guides/safety-best-practices#safety-identifiers).<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? User { get; set; }

        /// <summary>
        /// A stable identifier used to help detect users of your application that may be violating OpenAI's usage policies.<br/>
        /// The IDs should be a string that uniquely identifies each user, with a maximum length of 64 characters. We recommend hashing their username or email address, in order to avoid sending us any identifying information. [Learn more](/docs/guides/safety-best-practices#safety-identifiers).<br/>
        /// Example: safety-identifier-1234
        /// </summary>
        /// <example>safety-identifier-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// Used by OpenAI to cache responses for similar requests to optimize your cache hit rates. Replaces the `user` field. [Learn more](/docs/guides/prompt-caching).<br/>
        /// Example: prompt-cache-key-1234
        /// </summary>
        /// <example>prompt-cache-key-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::tryAGI.OpenAI.ServiceTierEnum? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_retention")]
        public global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention2? PromptCacheRetention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseProperties" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="safetyIdentifier">
        /// A stable identifier used to help detect users of your application that may be violating OpenAI's usage policies.<br/>
        /// The IDs should be a string that uniquely identifies each user, with a maximum length of 64 characters. We recommend hashing their username or email address, in order to avoid sending us any identifying information. [Learn more](/docs/guides/safety-best-practices#safety-identifiers).<br/>
        /// Example: safety-identifier-1234
        /// </param>
        /// <param name="promptCacheKey">
        /// Used by OpenAI to cache responses for similar requests to optimize your cache hit rates. Replaces the `user` field. [Learn more](/docs/guides/prompt-caching).<br/>
        /// Example: prompt-cache-key-1234
        /// </param>
        /// <param name="serviceTier"></param>
        /// <param name="promptCacheRetention"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelResponseProperties(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            int? topLogprobs,
            double? temperature,
            double? topP,
            string? safetyIdentifier,
            string? promptCacheKey,
            global::tryAGI.OpenAI.ServiceTierEnum? serviceTier,
            global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention2? promptCacheRetention)
        {
            this.Metadata = metadata;
            this.TopLogprobs = topLogprobs;
            this.Temperature = temperature;
            this.TopP = topP;
            this.SafetyIdentifier = safetyIdentifier;
            this.PromptCacheKey = promptCacheKey;
            this.ServiceTier = serviceTier;
            this.PromptCacheRetention = promptCacheRetention;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseProperties" /> class.
        /// </summary>
        public ModelResponseProperties()
        {
        }
    }
}