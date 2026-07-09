
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
    /// </summary>
    public sealed partial class BetaPromptCacheBreakpointParam
    {
        /// <summary>
        /// The breakpoint mode. Always `explicit`.<br/>
        /// Default Value: explicit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode.Explicit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointParamModeJsonConverter))]
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode Mode { get; set; } = global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode.Explicit;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheBreakpointParam" /> class.
        /// </summary>
        /// <param name="mode">
        /// The breakpoint mode. Always `explicit`.<br/>
        /// Default Value: explicit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPromptCacheBreakpointParam(
            global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode mode = global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode.Explicit)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheBreakpointParam" /> class.
        /// </summary>
        public BetaPromptCacheBreakpointParam()
        {
        }

    }
}