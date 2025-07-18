
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A chat completion message generated by the model.
    /// </summary>
    public sealed partial class ChatCompletionResponseMessage
    {
        /// <summary>
        /// Annotations for the message, when applicable, as when using the<br/>
        /// [web search tool](/docs/guides/tools-web-search?api-mode=chat).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>? Annotations { get; set; }

        /// <summary>
        /// If the audio output modality is requested, this object contains data<br/>
        /// about the audio response from the model. [Learn more](/docs/guides/audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageAudio? Audio { get; set; }

        /// <summary>
        /// The contents of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// The refusal message generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// The role of the author of this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionResponseMessageRole Role { get; set; }

        /// <summary>
        /// The tool calls generated by the model, such as function calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessage" /> class.
        /// </summary>
        /// <param name="annotations">
        /// Annotations for the message, when applicable, as when using the<br/>
        /// [web search tool](/docs/guides/tools-web-search?api-mode=chat).
        /// </param>
        /// <param name="audio">
        /// If the audio output modality is requested, this object contains data<br/>
        /// about the audio response from the model. [Learn more](/docs/guides/audio).
        /// </param>
        /// <param name="content">
        /// The contents of the message.
        /// </param>
        /// <param name="refusal">
        /// The refusal message generated by the model.
        /// </param>
        /// <param name="role">
        /// The role of the author of this message.
        /// </param>
        /// <param name="toolCalls">
        /// The tool calls generated by the model, such as function calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseMessage(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionResponseMessageAnnotation>? annotations,
            global::tryAGI.OpenAI.ChatCompletionResponseMessageAudio? audio,
            string? content,
            string? refusal,
            global::tryAGI.OpenAI.ChatCompletionResponseMessageRole role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCall>? toolCalls)
        {
            this.Annotations = annotations;
            this.Audio = audio;
            this.Content = content;
            this.Refusal = refusal;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessage" /> class.
        /// </summary>
        public ChatCompletionResponseMessage()
        {
        }
    }
}