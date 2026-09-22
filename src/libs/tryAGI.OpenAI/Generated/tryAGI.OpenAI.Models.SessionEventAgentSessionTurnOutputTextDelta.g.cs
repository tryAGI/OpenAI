
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when text is appended to an output text content part.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnOutputTextDelta
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.output_text.delta`.<br/>
        /// Default Value: agent.session.turn.output_text.delta
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType.AgentSessionTurnOutputTextDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnOutputTextDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType.AgentSessionTurnOutputTextDelta;

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
        /// The text that was appended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnOutputTextDelta" /> class.
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
        /// <param name="delta">
        /// The text that was appended.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.output_text.delta`.<br/>
        /// Default Value: agent.session.turn.output_text.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnOutputTextDelta(
            string eventId,
            string sessionId,
            string itemId,
            long outputIndex,
            long contentIndex,
            string delta,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType.AgentSessionTurnOutputTextDelta)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnOutputTextDelta" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnOutputTextDelta()
        {
        }

    }
}