
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A user message containing input text, images, or JSON.
    /// </summary>
    public sealed partial class DecisionInputUserMessage
    {
        /// <summary>
        /// Default Value: user
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputUserMessageRole.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputUserMessageRoleJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputUserMessageRole Role { get; set; } = global::tryAGI.OpenAI.DecisionInputUserMessageRole.User;

        /// <summary>
        /// A text string or an ordered list of text, image, and JSON parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInputContent Content { get; set; }

        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputUserMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputUserMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// A text string or an ordered list of text, image, and JSON parts.
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
        public DecisionInputUserMessage(
            global::tryAGI.OpenAI.DecisionInputContent content,
            global::tryAGI.OpenAI.DecisionInputUserMessageType? type,
            global::tryAGI.OpenAI.DecisionInputUserMessageRole role = global::tryAGI.OpenAI.DecisionInputUserMessageRole.User)
        {
            this.Role = role;
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputUserMessage" /> class.
        /// </summary>
        public DecisionInputUserMessage()
        {
        }

    }
}