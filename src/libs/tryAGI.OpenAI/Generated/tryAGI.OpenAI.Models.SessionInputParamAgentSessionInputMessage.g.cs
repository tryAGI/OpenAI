
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Adds one or more user messages and starts a turn.
    /// </summary>
    public sealed partial class SessionInputParamAgentSessionInputMessage
    {
        /// <summary>
        /// The type of the object. Always `agent.session.input.message`.<br/>
        /// Default Value: agent.session.input.message
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType.AgentSessionInputMessage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputMessageTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType Type { get; set; } = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType.AgentSessionInputMessage;

        /// <summary>
        /// The user messages to add to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputMessage" /> class.
        /// </summary>
        /// <param name="input">
        /// The user messages to add to the session.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.input.message`.<br/>
        /// Default Value: agent.session.input.message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInputParamAgentSessionInputMessage(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam> input,
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType type = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType.AgentSessionInputMessage)
        {
            this.Type = type;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputMessage" /> class.
        /// </summary>
        public SessionInputParamAgentSessionInputMessage()
        {
        }

    }
}