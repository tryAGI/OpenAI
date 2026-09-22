
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Cancels the session's active turn.
    /// </summary>
    public sealed partial class SessionInputParamAgentSessionInputCancel
    {
        /// <summary>
        /// The type of the object. Always `agent.session.input.cancel`.<br/>
        /// Default Value: agent.session.input.cancel
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType.AgentSessionInputCancel</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputCancelTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType Type { get; set; } = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType.AgentSessionInputCancel;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputCancel" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `agent.session.input.cancel`.<br/>
        /// Default Value: agent.session.input.cancel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInputParamAgentSessionInputCancel(
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType type = global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType.AgentSessionInputCancel)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInputParamAgentSessionInputCancel" /> class.
        /// </summary>
        public SessionInputParamAgentSessionInputCancel()
        {
        }

    }
}