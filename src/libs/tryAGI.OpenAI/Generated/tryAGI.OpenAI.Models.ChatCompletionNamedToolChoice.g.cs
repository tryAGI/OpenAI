
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies a tool the model should use. Use to force the model to call a specific function.
    /// </summary>
    public sealed partial class ChatCompletionNamedToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceFunction Function { get; set; }

        /// <summary>
        /// For function calling, the type is always `function`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionNamedToolChoiceTypeJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionNamedToolChoice" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type">
        /// For function calling, the type is always `function`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionNamedToolChoice(
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceFunction function,
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceType type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionNamedToolChoice" /> class.
        /// </summary>
        public ChatCompletionNamedToolChoice()
        {
        }
    }
}