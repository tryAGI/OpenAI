
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
    /// </summary>
    public sealed partial class DecisionInputImagePromptCacheBreakpoint
    {
        /// <summary>
        /// The breakpoint mode. Always `explicit`.<br/>
        /// Default Value: explicit
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode.Explicit</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputImagePromptCacheBreakpointModeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode Mode { get; set; } = global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode.Explicit;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputImagePromptCacheBreakpoint" /> class.
        /// </summary>
        /// <param name="mode">
        /// The breakpoint mode. Always `explicit`.<br/>
        /// Default Value: explicit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputImagePromptCacheBreakpoint(
            global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode mode = global::tryAGI.OpenAI.DecisionInputImagePromptCacheBreakpointMode.Explicit)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputImagePromptCacheBreakpoint" /> class.
        /// </summary>
        public DecisionInputImagePromptCacheBreakpoint()
        {
        }

    }
}