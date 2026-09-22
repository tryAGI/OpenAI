
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a reasoning summary content part is added.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnReasoningSummaryPartAdded
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.reasoning_summary_part.added`.<br/>
        /// Default Value: agent.session.turn.reasoning_summary_part.added
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType.AgentSessionTurnReasoningSummaryPartAdded</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartAddedTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType.AgentSessionTurnReasoningSummaryPartAdded;

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
        /// The initial summary part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SummaryTextResource Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnReasoningSummaryPartAdded" /> class.
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
        /// <param name="part">
        /// The initial summary part.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.reasoning_summary_part.added`.<br/>
        /// Default Value: agent.session.turn.reasoning_summary_part.added
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnReasoningSummaryPartAdded(
            string eventId,
            string sessionId,
            string itemId,
            long outputIndex,
            long summaryIndex,
            global::tryAGI.OpenAI.SummaryTextResource part,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType.AgentSessionTurnReasoningSummaryPartAdded)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Part = part ?? throw new global::System.ArgumentNullException(nameof(part));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnReasoningSummaryPartAdded" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnReasoningSummaryPartAdded()
        {
        }

    }
}