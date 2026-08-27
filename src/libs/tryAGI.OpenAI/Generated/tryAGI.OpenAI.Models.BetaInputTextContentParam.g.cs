
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A text input to the model.
    /// </summary>
    public sealed partial class BetaInputTextContentParam
    {
        /// <summary>
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaInputTextContentParamType.InputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaInputTextContentParamType Type { get; set; } = global::tryAGI.OpenAI.BetaInputTextContentParamType.InputText;

        /// <summary>
        /// The text input to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputTextContentParam" /> class.
        /// </summary>
        /// <param name="text">
        /// The text input to the model.
        /// </param>
        /// <param name="promptCacheBreakpoint"></param>
        /// <param name="type">
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInputTextContentParam(
            string text,
            global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam? promptCacheBreakpoint,
            global::tryAGI.OpenAI.BetaInputTextContentParamType type = global::tryAGI.OpenAI.BetaInputTextContentParamType.InputText)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputTextContentParam" /> class.
        /// </summary>
        public BetaInputTextContentParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaInputTextContentParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaInputTextContentParam FromText(string text)
        {
            return new BetaInputTextContentParam
            {
                Text = text,
            };
        }

    }
}