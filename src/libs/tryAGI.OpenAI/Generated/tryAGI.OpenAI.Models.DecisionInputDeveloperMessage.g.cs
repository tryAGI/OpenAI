
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A developer message containing input text.
    /// </summary>
    public sealed partial class DecisionInputDeveloperMessage
    {
        /// <summary>
        /// Default Value: developer
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputDeveloperMessageRole.Developer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputDeveloperMessageRoleJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessageRole Role { get; set; } = global::tryAGI.OpenAI.DecisionInputDeveloperMessageRole.Developer;

        /// <summary>
        /// A text string or an ordered list of input text parts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputDeveloperContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.DecisionInputDeveloperContent Content { get; set; }

        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputDeveloperMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputDeveloperMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputDeveloperMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// A text string or an ordered list of input text parts.
        /// </param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// Default Value: developer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputDeveloperMessage(
            global::tryAGI.OpenAI.DecisionInputDeveloperContent content,
            global::tryAGI.OpenAI.DecisionInputDeveloperMessageType? type,
            global::tryAGI.OpenAI.DecisionInputDeveloperMessageRole role = global::tryAGI.OpenAI.DecisionInputDeveloperMessageRole.Developer)
        {
            this.Role = role;
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputDeveloperMessage" /> class.
        /// </summary>
        public DecisionInputDeveloperMessage()
        {
        }

    }
}