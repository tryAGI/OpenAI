
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a code interpreter call is in progress.
    /// </summary>
    public sealed partial class BetaResponseCodeInterpreterCallInProgressEvent
    {
        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.in_progress`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInProgressEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType Type { get; set; }

        /// <summary>
        /// The index of the output item in the response for which the code interpreter call is in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The unique identifier of the code interpreter tool call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The sequence number of this event, used to order streaming events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCodeInterpreterCallInProgressEvent" /> class.
        /// </summary>
        /// <param name="outputIndex">
        /// The index of the output item in the response for which the code interpreter call is in progress.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the code interpreter tool call item.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event, used to order streaming events.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call.in_progress`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseCodeInterpreterCallInProgressEvent(
            int outputIndex,
            string itemId,
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType type)
        {
            this.Agent = agent;
            this.Type = type;
            this.OutputIndex = outputIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCodeInterpreterCallInProgressEvent" /> class.
        /// </summary>
        public BetaResponseCodeInterpreterCallInProgressEvent()
        {
        }

    }
}