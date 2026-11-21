
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies a tool the model should use. Use to force the model to call a specific custom tool.
    /// </summary>
    public sealed partial class ChatCompletionNamedToolChoiceCustom
    {
        /// <summary>
        /// For custom tool calling, the type is always `custom`.
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionNamedToolChoiceCustom" /> class.
        /// </summary>
        /// <param name="custom"></param>
        /// <param name="type">
        /// For custom tool calling, the type is always `custom`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionNamedToolChoiceCustom(
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom custom,
            string type = "custom")
        {
            this.Type = type;
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionNamedToolChoiceCustom" /> class.
        /// </summary>
        public ChatCompletionNamedToolChoiceCustom()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionNamedToolChoiceCustom"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionNamedToolChoiceCustom FromCustom(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom custom)
        {
            return new ChatCompletionNamedToolChoiceCustom
            {
                Custom = custom,
            };
        }

    }
}