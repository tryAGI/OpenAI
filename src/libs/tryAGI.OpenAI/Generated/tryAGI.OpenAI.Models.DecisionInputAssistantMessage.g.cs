
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An assistant message containing output text or refusals.
    /// </summary>
    public sealed partial class DecisionInputAssistantMessage
    {
        /// <summary>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputAssistantMessageRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputAssistantMessageRoleJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputAssistantMessageRole Role { get; set; } = global::tryAGI.OpenAI.DecisionInputAssistantMessageRole.Assistant;

        /// <summary>
        /// A text string or an ordered list of output text and refusal parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputAssistantContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInputAssistantContent Content { get; set; }

        /// <summary>
        /// The phase of an assistant message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public global::tryAGI.OpenAI.MessagePhaseParam? Phase { get; set; }

        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputAssistantMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputAssistantMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputAssistantMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// A text string or an ordered list of output text and refusal parts.
        /// </param>
        /// <param name="phase">
        /// The phase of an assistant message.
        /// </param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// Default Value: assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputAssistantMessage(
            global::tryAGI.OpenAI.DecisionInputAssistantContent content,
            global::tryAGI.OpenAI.MessagePhaseParam? phase,
            global::tryAGI.OpenAI.DecisionInputAssistantMessageType? type,
            global::tryAGI.OpenAI.DecisionInputAssistantMessageRole role = global::tryAGI.OpenAI.DecisionInputAssistantMessageRole.Assistant)
        {
            this.Role = role;
            this.Content = content;
            this.Phase = phase;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputAssistantMessage" /> class.
        /// </summary>
        public DecisionInputAssistantMessage()
        {
        }

    }
}