
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a session starts processing a turn.
    /// </summary>
    public sealed partial class SessionEventAgentSessionInProgress
    {
        /// <summary>
        /// The type of the object. Always `agent.session.in_progress`.<br/>
        /// Default Value: agent.session.in_progress
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType.AgentSessionInProgress</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionInProgressTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType.AgentSessionInProgress;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The session that started processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionResource Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionInProgress" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="session">
        /// The session that started processing.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.in_progress`.<br/>
        /// Default Value: agent.session.in_progress
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionInProgress(
            string eventId,
            global::tryAGI.OpenAI.SessionResource session,
            global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType type = global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType.AgentSessionInProgress)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionInProgress" /> class.
        /// </summary>
        public SessionEventAgentSessionInProgress()
        {
        }

    }
}