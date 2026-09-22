
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a reasoning summary part is complete.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnReasoningSummaryPartDone
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.reasoning_summary_part.done`.<br/>
        /// Default Value: agent.session.turn.reasoning_summary_part.done
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType.AgentSessionTurnReasoningSummaryPartDone</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType.AgentSessionTurnReasoningSummaryPartDone;

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
        /// The index of the summary part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SummaryIndex { get; set; }

        /// <summary>
        /// The completed summary part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SummaryTextResource Part { get; set; }

        /// <summary>
        /// Present as `incomplete` when summary generation was interrupted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatusJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnReasoningSummaryPartDone" /> class.
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
        /// The index of the summary part.
        /// </param>
        /// <param name="part">
        /// The completed summary part.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="status">
        /// Present as `incomplete` when summary generation was interrupted.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.reasoning_summary_part.done`.<br/>
        /// Default Value: agent.session.turn.reasoning_summary_part.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnReasoningSummaryPartDone(
            string eventId,
            string sessionId,
            string itemId,
            long outputIndex,
            long summaryIndex,
            global::tryAGI.OpenAI.SummaryTextResource part,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus? status,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType.AgentSessionTurnReasoningSummaryPartDone)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Part = part ?? throw new global::System.ArgumentNullException(nameof(part));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnReasoningSummaryPartDone" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnReasoningSummaryPartDone()
        {
        }

    }
}