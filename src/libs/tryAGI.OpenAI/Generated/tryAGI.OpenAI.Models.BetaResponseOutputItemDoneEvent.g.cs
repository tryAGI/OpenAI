
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an output item is marked done.
    /// </summary>
    public sealed partial class BetaResponseOutputItemDoneEvent
    {
        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the event. Always `response.output_item.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that was marked done.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The output item that was marked done.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaOutputItemJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaOutputItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseOutputItemDoneEvent" /> class.
        /// </summary>
        /// <param name="outputIndex">
        /// The index of the output item that was marked done.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="item">
        /// The output item that was marked done.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.output_item.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseOutputItemDoneEvent(
            int outputIndex,
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaOutputItem item,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType type)
        {
            this.Agent = agent;
            this.Type = type;
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseOutputItemDoneEvent" /> class.
        /// </summary>
        public BetaResponseOutputItemDoneEvent()
        {
        }

    }
}