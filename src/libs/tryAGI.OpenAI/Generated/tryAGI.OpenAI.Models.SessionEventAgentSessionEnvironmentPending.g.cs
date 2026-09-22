
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted while a session environment is being prepared.
    /// </summary>
    public sealed partial class SessionEventAgentSessionEnvironmentPending
    {
        /// <summary>
        /// The type of the object. Always `agent.session.environment.pending`.<br/>
        /// Default Value: agent.session.environment.pending
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType.AgentSessionEnvironmentPending</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentPendingTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType.AgentSessionEnvironmentPending;

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
        /// The ID of the turn associated with the event, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// The current environment state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionEnvironmentStateResource Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionEnvironmentPending" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="environment">
        /// The current environment state.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.environment.pending`.<br/>
        /// Default Value: agent.session.environment.pending
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionEnvironmentPending(
            string eventId,
            string sessionId,
            global::tryAGI.OpenAI.SessionEnvironmentStateResource environment,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType type = global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType.AgentSessionEnvironmentPending)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionEnvironmentPending" /> class.
        /// </summary>
        public SessionEventAgentSessionEnvironmentPending()
        {
        }

    }
}