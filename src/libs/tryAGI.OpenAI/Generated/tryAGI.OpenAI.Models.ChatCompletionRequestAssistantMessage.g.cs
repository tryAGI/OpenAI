
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Messages sent by the model in response to user messages.
    /// </summary>
    public sealed partial class ChatCompletionRequestAssistantMessage
    {
        /// <summary>
        /// The contents of the assistant message. Required unless `tool_calls` or `function_call` is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>))]
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>? Content { get; set; }

        /// <summary>
        /// The refusal message by the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// The role of the messages author, in this case `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter))]
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole Role { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Data about a previous audio response from the model. <br/>
        /// [Learn more](/docs/guides/audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio? Audio { get; set; }

        /// <summary>
        /// The tool calls generated by the model, such as function calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the assistant message. Required unless `tool_calls` or `function_call` is specified.
        /// </param>
        /// <param name="refusal">
        /// The refusal message by the assistant.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `assistant`.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
        /// <param name="audio">
        /// Data about a previous audio response from the model. <br/>
        /// [Learn more](/docs/guides/audio).
        /// </param>
        /// <param name="toolCalls">
        /// The tool calls generated by the model, such as function calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestAssistantMessage(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageContentPart>>? content,
            string? refusal,
            global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageRole role,
            string? name,
            global::tryAGI.OpenAI.ChatCompletionRequestAssistantMessageAudio? audio,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionMessageToolCall>? toolCalls)
        {
            this.Content = content;
            this.Refusal = refusal;
            this.Role = role;
            this.Name = name;
            this.Audio = audio;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessage" /> class.
        /// </summary>
        public ChatCompletionRequestAssistantMessage()
        {
        }
    }
}