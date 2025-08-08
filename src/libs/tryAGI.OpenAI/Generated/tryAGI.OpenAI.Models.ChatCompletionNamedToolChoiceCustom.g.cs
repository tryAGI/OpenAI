
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies a tool the model should use. Use to force the model to call a specific custom tool.
    /// </summary>
    public sealed partial class ChatCompletionNamedToolChoiceCustom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomCustom Custom { get; set; }

        /// <summary>
        /// For custom tool calling, the type is always `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceCustomTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType Type { get; set; }

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
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustomType type)
        {
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionNamedToolChoiceCustom" /> class.
        /// </summary>
        public ChatCompletionNamedToolChoiceCustom()
        {
        }
    }
}