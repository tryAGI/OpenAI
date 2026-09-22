
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when text is appended to a reasoning summary.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnReasoningSummaryTextDelta
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.reasoning_summary_text.delta`.<br/>
        /// Default Value: agent.session.turn.reasoning_summary_text.delta
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType.AgentSessionTurnReasoningSummaryTextDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryTextDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType.AgentSessionTurnReasoningSummaryTextDelta;

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
        /// The ID of the reasoning item.
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
        /// The index of the summary content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SummaryIndex { get; set; }

        /// <summary>
        /// The summary text that was appended.
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
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnReasoningSummaryTextDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the reasoning item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the item in the turn output.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary content part.
        /// </param>
        /// <param name="delta">
        /// The summary text that was appended.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.reasoning_summary_text.delta`.<br/>
        /// Default Value: agent.session.turn.reasoning_summary_text.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnReasoningSummaryTextDelta(
            string eventId,
            string sessionId,
            string itemId,
            long outputIndex,
            long summaryIndex,
            string delta,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType.AgentSessionTurnReasoningSummaryTextDelta)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnReasoningSummaryTextDelta" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnReasoningSummaryTextDelta()
        {
        }

    }
}