
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A user message containing input text or images, a developer or system message containing input text, or an assistant message containing output text or refusals. System messages are rendered as developer messages.
    /// </summary>
    public sealed partial class DecisionInputMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInputMessageRole Role { get; set; }

        /// <summary>
        /// Text evidence or an ordered list of text and image parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInputContent Content { get; set; }

        /// <summary>
        /// The phase of an assistant message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public global::tryAGI.OpenAI.MessagePhaseParam? Phase { get; set; }

        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content">
        /// Text evidence or an ordered list of text and image parts.
        /// </param>
        /// <param name="phase">
        /// The phase of an assistant message.
        /// </param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputMessage(
            global::tryAGI.OpenAI.DecisionInputMessageRole role,
            global::tryAGI.OpenAI.DecisionInputContent content,
            global::tryAGI.OpenAI.MessagePhaseParam? phase,
            global::tryAGI.OpenAI.DecisionInputMessageType? type)
        {
            this.Role = role;
            this.Content = content;
            this.Phase = phase;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputMessage" /> class.
        /// </summary>
        public DecisionInputMessage()
        {
        }

    }
}