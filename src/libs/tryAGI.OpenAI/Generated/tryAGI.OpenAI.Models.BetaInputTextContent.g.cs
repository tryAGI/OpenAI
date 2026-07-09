
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text input to the model.
    /// </summary>
    public sealed partial class BetaInputTextContent
    {
        /// <summary>
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaInputTextContentType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaInputTextContentType Type { get; set; } = global::tryAGI.OpenAI.BetaInputTextContentType.InputText;

        /// <summary>
        /// The text input to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputTextContent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text input to the model.
        /// </param>
        /// <param name="promptCacheBreakpoint">
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInputTextContent(
            string text,
            global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? promptCacheBreakpoint,
            global::tryAGI.OpenAI.BetaInputTextContentType type = global::tryAGI.OpenAI.BetaInputTextContentType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputTextContent" /> class.
        /// </summary>
        public BetaInputTextContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaInputTextContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaInputTextContent FromText(string text)
        {
            return new BetaInputTextContent
            {
                Text = text,
            };
        }

    }
}