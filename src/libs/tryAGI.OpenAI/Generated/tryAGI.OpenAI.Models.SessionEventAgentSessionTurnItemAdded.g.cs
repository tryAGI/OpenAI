
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an item is added to a turn.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnItemAdded
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.item.added`.<br/>
        /// Default Value: agent.session.turn.item.added
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType.AgentSessionTurnItemAdded</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnItemAddedTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType.AgentSessionTurnItemAdded;

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
        /// The index of the item in the turn output, when the item is agent output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public long? OutputIndex { get; set; }

        /// <summary>
        /// The item that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionTurnItemResource Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnItemAdded" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="item">
        /// The item that was added.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the item in the turn output, when the item is agent output.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.item.added`.<br/>
        /// Default Value: agent.session.turn.item.added
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnItemAdded(
            string eventId,
            string sessionId,
            global::tryAGI.OpenAI.SessionTurnItemResource item,
            string? turnId,
            long? outputIndex,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType.AgentSessionTurnItemAdded)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.OutputIndex = outputIndex;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnItemAdded" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnItemAdded()
        {
        }

    }
}