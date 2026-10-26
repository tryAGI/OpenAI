
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Marks the exact end of a reusable prompt prefix. When `ttl` is omitted, the breakpoint inherits the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
    /// </summary>
    public sealed partial class PromptCacheBreakpointConfig
    {
        /// <summary>
        /// The breakpoint mode. Always `explicit`.<br/>
        /// Default Value: explicit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode.Explicit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode Mode { get; set; } = global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode.Explicit;

        /// <summary>
        /// The minimum lifetime of this cache breakpoint. Defaults to the request TTL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigTtlJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheBreakpointConfigTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheBreakpointConfig" /> class.
        /// </summary>
        /// <param name="ttl">
        /// The minimum lifetime of this cache breakpoint. Defaults to the request TTL.
        /// </param>
        /// <param name="mode">
        /// The breakpoint mode. Always `explicit`.<br/>
        /// Default Value: explicit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheBreakpointConfig(
            global::tryAGI.OpenAI.PromptCacheBreakpointConfigTtl? ttl,
            global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode mode = global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode.Explicit)
        {
            this.Mode = mode;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheBreakpointConfig" /> class.
        /// </summary>
        public PromptCacheBreakpointConfig()
        {
        }

    }
}