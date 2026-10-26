
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Marks the exact end of a reusable prompt prefix. When `ttl` is omitted, the breakpoint inherits the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
    /// </summary>
    public sealed partial class PromptCacheBreakpointParam
    {
        /// <summary>
        /// The breakpoint mode. Always `explicit`.<br/>
        /// Default Value: explicit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PromptCacheBreakpointParamMode.Explicit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamMode Mode { get; set; } = global::tryAGI.OpenAI.PromptCacheBreakpointParamMode.Explicit;

        /// <summary>
        /// The minimum lifetime of this cache breakpoint. Defaults to the request TTL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamTtlJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheBreakpointParamTtl? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheBreakpointParam" /> class.
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
        public PromptCacheBreakpointParam(
            global::tryAGI.OpenAI.PromptCacheBreakpointParamTtl? ttl,
            global::tryAGI.OpenAI.PromptCacheBreakpointParamMode mode = global::tryAGI.OpenAI.PromptCacheBreakpointParamMode.Explicit)
        {
            this.Mode = mode;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheBreakpointParam" /> class.
        /// </summary>
        public PromptCacheBreakpointParam()
        {
        }

    }
}