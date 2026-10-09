
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A user message containing text or images.
    /// </summary>
    public sealed partial class DecisionInputMessage
    {
        /// <summary>
        /// Default Value: user
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputMessageRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputMessageRoleJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputMessageRole Role { get; set; } = global::tryAGI.OpenAI.DecisionInputMessageRole.User;

        /// <summary>
        /// Text evidence or an ordered list of text and image parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInputContent Content { get; set; }

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
        /// <param name="content">
        /// Text evidence or an ordered list of text and image parts.
        /// </param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputMessage(
            global::tryAGI.OpenAI.DecisionInputContent content,
            global::tryAGI.OpenAI.DecisionInputMessageType? type,
            global::tryAGI.OpenAI.DecisionInputMessageRole role = global::tryAGI.OpenAI.DecisionInputMessageRole.User)
        {
            this.Role = role;
            this.Content = content;
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