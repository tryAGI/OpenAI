
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A system message containing input text.
    /// </summary>
    public sealed partial class DecisionInputSystemMessage
    {
        /// <summary>
        /// Default Value: system
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DecisionInputSystemMessageRole.System</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputSystemMessageRoleJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputSystemMessageRole Role { get; set; } = global::tryAGI.OpenAI.DecisionInputSystemMessageRole.System;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DecisionInputSystemMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.DecisionInputSystemMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// A text string or an ordered list of input text parts.
        /// </param>
        /// <param name="type">
        /// Default Value: message
        /// </param>
        /// <param name="role">
        /// Default Value: system
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionInputSystemMessage(
            global::tryAGI.OpenAI.DecisionInputDeveloperContent content,
            global::tryAGI.OpenAI.DecisionInputSystemMessageType? type,
            global::tryAGI.OpenAI.DecisionInputSystemMessageRole role = global::tryAGI.OpenAI.DecisionInputSystemMessageRole.System)
        {
            this.Role = role;
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionInputSystemMessage" /> class.
        /// </summary>
        public DecisionInputSystemMessage()
        {
        }

    }
}