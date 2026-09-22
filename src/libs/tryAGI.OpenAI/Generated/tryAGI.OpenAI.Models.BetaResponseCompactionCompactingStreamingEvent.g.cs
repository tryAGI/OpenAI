
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when new summary content is sampled for a compaction trigger. Contains no summary content.
    /// </summary>
    public sealed partial class BetaResponseCompactionCompactingStreamingEvent
    {
        /// <summary>
        /// The type of the event, always `response.compaction.compacting`.<br/>
        /// Default Value: response.compaction.compacting
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType.ResponseCompactionCompacting</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseCompactionCompactingStreamingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType Type { get; set; } = global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType.ResponseCompactionCompacting;

        /// <summary>
        /// The sequence number of the event that was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The index of the compaction output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The ID of the compaction output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCompactionCompactingStreamingEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number of the event that was emitted.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the compaction output item.
        /// </param>
        /// <param name="itemId">
        /// The ID of the compaction output item.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event, always `response.compaction.compacting`.<br/>
        /// Default Value: response.compaction.compacting
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseCompactionCompactingStreamingEvent(
            int sequenceNumber,
            int outputIndex,
            string itemId,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType type = global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType.ResponseCompactionCompacting)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Agent = agent;
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCompactionCompactingStreamingEvent" /> class.
        /// </summary>
        public BetaResponseCompactionCompactingStreamingEvent()
        {
        }

    }
}