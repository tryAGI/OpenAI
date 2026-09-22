
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The canonical public representation of a session turn.
    /// </summary>
    public sealed partial class TurnResource
    {
        /// <summary>
        /// The ID of the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.session.turn`.<br/>
        /// Default Value: agent.session.turn
        /// </summary>
        /// <default>global::tryAGI.OpenAI.TurnObjectResource.AgentSessionTurn</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TurnObjectResourceJsonConverter))]
        public global::tryAGI.OpenAI.TurnObjectResource Object { get; set; } = global::tryAGI.OpenAI.TurnObjectResource.AgentSessionTurn;

        /// <summary>
        /// The ID of the session that owns the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The ID of the agent that ran the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The ID of the subagent that ran the turn, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagent_id")]
        public string? SubagentId { get; set; }

        /// <summary>
        /// The current status of the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.TurnStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.TurnStatusResource Status { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, used to order the turn by creation time. Subagent turns use their start time, falling back to completion time or the subagent opening time when the preceding timestamps are unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the turn started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? StartedAt { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the turn reached a terminal state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// A customer-safe error. Non-null only for a failed turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.SessionTurnErrorResource? Error { get; set; }

        /// <summary>
        /// Best-effort token usage for the turn, or null if unknown. Recorded usage may change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::tryAGI.OpenAI.TokenUsageResource? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the turn.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session that owns the turn.
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent that ran the turn.
        /// </param>
        /// <param name="status">
        /// The current status of the turn.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp, in seconds, used to order the turn by creation time. Subagent turns use their start time, falling back to completion time or the subagent opening time when the preceding timestamps are unavailable.
        /// </param>
        /// <param name="subagentId">
        /// The ID of the subagent that ran the turn, if applicable.
        /// </param>
        /// <param name="startedAt">
        /// The Unix timestamp, in seconds, when the turn started.
        /// </param>
        /// <param name="completedAt">
        /// The Unix timestamp, in seconds, when the turn reached a terminal state.
        /// </param>
        /// <param name="error">
        /// A customer-safe error. Non-null only for a failed turn.
        /// </param>
        /// <param name="usage">
        /// Best-effort token usage for the turn, or null if unknown. Recorded usage may change.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.session.turn`.<br/>
        /// Default Value: agent.session.turn
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnResource(
            string id,
            string sessionId,
            string agentId,
            global::tryAGI.OpenAI.TurnStatusResource status,
            global::System.DateTimeOffset createdAt,
            string? subagentId,
            global::System.DateTimeOffset? startedAt,
            global::System.DateTimeOffset? completedAt,
            global::tryAGI.OpenAI.SessionTurnErrorResource? error,
            global::tryAGI.OpenAI.TokenUsageResource? usage,
            global::tryAGI.OpenAI.TurnObjectResource @object = global::tryAGI.OpenAI.TurnObjectResource.AgentSessionTurn)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.SubagentId = subagentId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Error = error;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnResource" /> class.
        /// </summary>
        public TurnResource()
        {
        }

    }
}