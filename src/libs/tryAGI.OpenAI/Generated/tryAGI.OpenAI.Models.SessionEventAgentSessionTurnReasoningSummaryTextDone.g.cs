
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a reasoning summary content part is complete.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnReasoningSummaryTextDone
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.reasoning_summary_text.done`.<br/>
        /// Default Value: agent.session.turn.reasoning_summary_text.done
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType.AgentSessionTurnReasoningSummaryTextDone</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryTextDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType.AgentSessionTurnReasoningSummaryTextDone;

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
        /// The complete reasoning summary text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnReasoningSummaryTextDone" /> class.
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
        /// <param name="text">
        /// The complete reasoning summary text.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.reasoning_summary_text.done`.<br/>
        /// Default Value: agent.session.turn.reasoning_summary_text.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnReasoningSummaryTextDone(
            string eventId,
            string sessionId,
            string itemId,
            long outputIndex,
            long summaryIndex,
            string text,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType.AgentSessionTurnReasoningSummaryTextDone)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnReasoningSummaryTextDone" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnReasoningSummaryTextDone()
        {
        }

    }
}