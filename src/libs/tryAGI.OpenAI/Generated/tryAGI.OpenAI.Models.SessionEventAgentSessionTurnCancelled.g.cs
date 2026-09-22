
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a turn is cancelled.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnCancelled
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.cancelled`.<br/>
        /// Default Value: agent.session.turn.cancelled
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType.AgentSessionTurnCancelled</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnCancelledTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType.AgentSessionTurnCancelled;

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
        /// The cancelled turn.
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
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnCancelled" /> class.
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
        /// The cancelled turn.
        /// </param>
        /// <param name="usage">
        /// Token usage by the root agent during the turn, when available.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.cancelled`.<br/>
        /// Default Value: agent.session.turn.cancelled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnCancelled(
            string eventId,
            string sessionId,
            string turnId,
            global::tryAGI.OpenAI.TurnResource turn,
            global::tryAGI.OpenAI.TokenUsageResource? usage,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType.AgentSessionTurnCancelled)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Turn = turn ?? throw new global::System.ArgumentNullException(nameof(turn));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnCancelled" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnCancelled()
        {
        }

    }
}