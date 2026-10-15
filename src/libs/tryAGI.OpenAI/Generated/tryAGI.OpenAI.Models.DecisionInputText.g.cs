
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionInputText
    {
        /// <summary>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputTextType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputTextTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputTextType Type { get; set; } = global::tryAGI.OpenAI.DecisionInputTextType.InputText;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpoint? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputText" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="promptCacheBreakpoint">
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </param>
        /// <param name="type">
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputText(
            string text,
            global::tryAGI.OpenAI.DecisionInputTextPromptCacheBreakpoint? promptCacheBreakpoint,
            global::tryAGI.OpenAI.DecisionInputTextType type = global::tryAGI.OpenAI.DecisionInputTextType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputText" /> class.
        /// </summary>
        public DecisionInputText()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DecisionInputText"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DecisionInputText FromText(string text)
        {
            return new DecisionInputText
            {
                Text = text,
            };
        }

    }
}