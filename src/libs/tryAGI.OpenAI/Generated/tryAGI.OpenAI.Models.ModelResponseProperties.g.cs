
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelResponseProperties
    {
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Used by OpenAI to cache responses for similar requests to optimize your cache hit rates. Replaces the `user` field. [Learn more](https://platform.openai.com/docs/guides/prompt-caching).<br/>
        /// Example: prompt-cache-key-1234
        /// </summary>
        /// <example>prompt-cache-key-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// A stable identifier used to help detect users of your application that may be violating OpenAI's usage policies. <br/>
        /// The IDs should be a string that uniquely identifies each user. We recommend hashing their username or email address, in order to avoid sending us any identifying information. [Learn more](https://platform.openai.com/docs/guides/safety-best-practices#safety-identifiers).<br/>
        /// Example: safety-identifier-1234
        /// </summary>
        /// <example>safety-identifier-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// Specifies the processing type used for serving the request.<br/>
        ///   - If set to 'auto', then the request will be processed with the service tier configured in the Project settings. Unless otherwise configured, the Project will use 'default'.<br/>
        ///   - If set to 'default', then the request will be processed with the standard pricing and performance for the selected model.<br/>
        ///   - If set to '[flex](https://platform.openai.com/docs/guides/flex-processing)' or 'priority', then the request will be processed with the corresponding service tier. [Contact sales](https://openai.com/contact-sales) to learn more about Priority processing.<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When the `service_tier` parameter is set, the response body will include the `service_tier` value based on the processing mode actually used to serve the request. This response value may be different from the value set in the parameter.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ServiceTierJsonConverter))]
        public global::tryAGI.OpenAI.ServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling,<br/>
        /// where the model considers the results of the tokens with top_p probability<br/>
        /// mass. So 0.1 means only the tokens comprising the top 10% probability mass<br/>
        /// are considered.<br/>
        /// We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// This field is being replaced by `safety_identifier` and `prompt_cache_key`. Use `prompt_cache_key` instead to maintain caching optimizations.<br/>
        /// A stable identifier for your end-users. <br/>
        /// Used to boost cache hit rates by better bucketing similar requests and  to help OpenAI detect and prevent abuse. [Learn more](https://platform.openai.com/docs/guides/safety-best-practices#safety-identifiers).<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? User { get; set; }

        /// <summary>
        /// Constrains the verbosity of the model's response. Lower values will result in<br/>
        /// more concise responses, while higher values will result in more verbose responses.<br/>
        /// Currently supported values are `low`, `medium`, and `high`.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VerbosityJsonConverter))]
        public global::tryAGI.OpenAI.Verbosity? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseProperties" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="promptCacheKey">
        /// Used by OpenAI to cache responses for similar requests to optimize your cache hit rates. Replaces the `user` field. [Learn more](https://platform.openai.com/docs/guides/prompt-caching).<br/>
        /// Example: prompt-cache-key-1234
        /// </param>
        /// <param name="safetyIdentifier">
        /// A stable identifier used to help detect users of your application that may be violating OpenAI's usage policies. <br/>
        /// The IDs should be a string that uniquely identifies each user. We recommend hashing their username or email address, in order to avoid sending us any identifying information. [Learn more](https://platform.openai.com/docs/guides/safety-best-practices#safety-identifiers).<br/>
        /// Example: safety-identifier-1234
        /// </param>
        /// <param name="serviceTier">
        /// Specifies the processing type used for serving the request.<br/>
        ///   - If set to 'auto', then the request will be processed with the service tier configured in the Project settings. Unless otherwise configured, the Project will use 'default'.<br/>
        ///   - If set to 'default', then the request will be processed with the standard pricing and performance for the selected model.<br/>
        ///   - If set to '[flex](https://platform.openai.com/docs/guides/flex-processing)' or 'priority', then the request will be processed with the corresponding service tier. [Contact sales](https://openai.com/contact-sales) to learn more about Priority processing.<br/>
        ///   - When not set, the default behavior is 'auto'.<br/>
        ///   When the `service_tier` parameter is set, the response body will include the `service_tier` value based on the processing mode actually used to serve the request. This response value may be different from the value set in the parameter.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the number of most likely tokens to<br/>
        /// return at each token position, each with an associated log probability.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling,<br/>
        /// where the model considers the results of the tokens with top_p probability<br/>
        /// mass. So 0.1 means only the tokens comprising the top 10% probability mass<br/>
        /// are considered.<br/>
        /// We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="verbosity">
        /// Constrains the verbosity of the model's response. Lower values will result in<br/>
        /// more concise responses, while higher values will result in more verbose responses.<br/>
        /// Currently supported values are `low`, `medium`, and `high`.<br/>
        /// Default Value: medium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelResponseProperties(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? promptCacheKey,
            string? safetyIdentifier,
            global::tryAGI.OpenAI.ServiceTier? serviceTier,
            double? temperature,
            int? topLogprobs,
            double? topP,
            global::tryAGI.OpenAI.Verbosity? verbosity)
        {
            this.Metadata = metadata;
            this.PromptCacheKey = promptCacheKey;
            this.SafetyIdentifier = safetyIdentifier;
            this.ServiceTier = serviceTier;
            this.Temperature = temperature;
            this.TopLogprobs = topLogprobs;
            this.TopP = topP;
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelResponseProperties" /> class.
        /// </summary>
        public ModelResponseProperties()
        {
        }
    }
}