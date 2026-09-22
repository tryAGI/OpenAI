
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted after a hosted sandbox is replaced. Conversation history survives; changes to the previous sandbox's files and processes do not.
    /// </summary>
    public sealed partial class SessionEventAgentSessionEnvironmentReset
    {
        /// <summary>
        /// The type of the object. Always `agent.session.environment.reset`.<br/>
        /// Default Value: agent.session.environment.reset
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType.AgentSessionEnvironmentReset</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentResetTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType.AgentSessionEnvironmentReset;

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
        /// The associated turn, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// The stable environment ID, retained across sandbox replacements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Monotonically increasing reset number. Repeated notifications share this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ResetCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionEnvironmentReset" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="environmentId">
        /// The stable environment ID, retained across sandbox replacements.
        /// </param>
        /// <param name="resetCount">
        /// Monotonically increasing reset number. Repeated notifications share this number.
        /// </param>
        /// <param name="turnId">
        /// The associated turn, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.environment.reset`.<br/>
        /// Default Value: agent.session.environment.reset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionEnvironmentReset(
            string eventId,
            string sessionId,
            string environmentId,
            long resetCount,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType type = global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType.AgentSessionEnvironmentReset)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.ResetCount = resetCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionEnvironmentReset" /> class.
        /// </summary>
        public SessionEventAgentSessionEnvironmentReset()
        {
        }

    }
}