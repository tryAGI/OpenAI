
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// A text input to the model.
    /// </summary>
    public sealed partial class InputTextContent
    {
        /// <summary>
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.Realtime.InputTextContentType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.InputTextContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.InputTextContentType Type { get; set; } = global::tryAGI.OpenAI.Realtime.InputTextContentType.InputText;

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
        public global::tryAGI.OpenAI.Realtime.PromptCacheBreakpointConfig? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTextContent" /> class.
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
        public InputTextContent(
            string text,
            global::tryAGI.OpenAI.Realtime.PromptCacheBreakpointConfig? promptCacheBreakpoint,
            global::tryAGI.OpenAI.Realtime.InputTextContentType type = global::tryAGI.OpenAI.Realtime.InputTextContentType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTextContent" /> class.
        /// </summary>
        public InputTextContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="InputTextContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static InputTextContent FromText(string text)
        {
            return new InputTextContent
            {
                Text = text,
            };
        }

    }
}