
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a turn fails.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnFailed
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.failed`.<br/>
        /// Default Value: agent.session.turn.failed
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType.AgentSessionTurnFailed</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnFailedTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType.AgentSessionTurnFailed;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the session associated with the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The ID of the turn associated with the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The failed turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.TurnResource Turn { get; set; }

        /// <summary>
        /// Token usage by the root agent during the turn, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::tryAGI.OpenAI.TokenUsageResource? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnFailed" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event.
        /// </param>
        /// <param name="turn">
        /// The failed turn.
        /// </param>
        /// <param name="usage">
        /// Token usage by the root agent during the turn, when available.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.failed`.<br/>
        /// Default Value: agent.session.turn.failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnFailed(
            string eventId,
            string sessionId,
            string turnId,
            global::tryAGI.OpenAI.TurnResource turn,
            global::tryAGI.OpenAI.TokenUsageResource? usage,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType.AgentSessionTurnFailed)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Turn = turn ?? throw new global::System.ArgumentNullException(nameof(turn));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnFailed" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnFailed()
        {
        }

    }
}