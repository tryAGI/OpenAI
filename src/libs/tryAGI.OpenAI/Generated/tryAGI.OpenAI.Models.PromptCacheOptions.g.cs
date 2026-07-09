
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The prompt-caching options that were applied to the response. Supported for `gpt-5.6` and later models.
    /// </summary>
    public sealed partial class PromptCacheOptions
    {
        /// <summary>
        /// The minimum lifetime applied to each cache breakpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheTTLEnum Ttl { get; set; }

        /// <summary>
        /// Whether implicit prompt-cache breakpoints were enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.PromptCacheModeEnum Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheOptions" /> class.
        /// </summary>
        /// <param name="mode">
        /// Whether implicit prompt-cache breakpoints were enabled.
        /// </param>
        /// <param name="ttl">
        /// The minimum lifetime applied to each cache breakpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheOptions(
            global::tryAGI.OpenAI.PromptCacheModeEnum mode,
            global::tryAGI.OpenAI.PromptCacheTTLEnum ttl)
        {
            this.Ttl = ttl;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheOptions" /> class.
        /// </summary>
        public PromptCacheOptions()
        {
        }

    }
}