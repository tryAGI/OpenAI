
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an output content part is complete.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnContentPartDone
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.content_part.done`.<br/>
        /// Default Value: agent.session.turn.content_part.done
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType.AgentSessionTurnContentPartDone</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnContentPartDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType.AgentSessionTurnContentPartDone;

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
        /// The ID of the message item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the item in the turn output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long OutputIndex { get; set; }

        /// <summary>
        /// The index of the content part in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentIndex { get; set; }

        /// <summary>
        /// The completed content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OutputTextResource Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnContentPartDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the message item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the item in the turn output.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part in the message.
        /// </param>
        /// <param name="part">
        /// The completed content part.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.content_part.done`.<br/>
        /// Default Value: agent.session.turn.content_part.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnContentPartDone(
            string eventId,
            string sessionId,
            string itemId,
            long outputIndex,
            long contentIndex,
            global::tryAGI.OpenAI.OutputTextResource part,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType.AgentSessionTurnContentPartDone)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Part = part ?? throw new global::System.ArgumentNullException(nameof(part));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnContentPartDone" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnContentPartDone()
        {
        }

    }
}