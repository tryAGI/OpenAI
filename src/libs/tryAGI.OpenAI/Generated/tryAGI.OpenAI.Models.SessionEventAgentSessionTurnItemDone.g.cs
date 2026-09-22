
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an output item is complete.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnItemDone
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.item.done`.<br/>
        /// Default Value: agent.session.turn.item.done
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType.AgentSessionTurnItemDone</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnItemDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType.AgentSessionTurnItemDone;

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
        /// The index of the output item in the turn output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long OutputIndex { get; set; }

        /// <summary>
        /// The completed output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AgentOutputItemResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AgentOutputItemResource Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnItemDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the turn output.
        /// </param>
        /// <param name="item">
        /// The completed output item.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.item.done`.<br/>
        /// Default Value: agent.session.turn.item.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnItemDone(
            string eventId,
            string sessionId,
            long outputIndex,
            global::tryAGI.OpenAI.AgentOutputItemResource item,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType.AgentSessionTurnItemDone)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.OutputIndex = outputIndex;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnItemDone" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnItemDone()
        {
        }

    }
}