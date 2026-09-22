
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A streaming event that indicated shell call output was incrementally added.
    /// </summary>
    public sealed partial class BetaResponseShellCallOutputContentDeltaStreamingEvent
    {
        /// <summary>
        /// The type of the event, always `response.shell_call_output_content.delta`.<br/>
        /// Default Value: response.shell_call_output_content.delta
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDeltaStreamingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType Type { get; set; } = global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta;

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
        /// The ID of the output item that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the shell command that produced output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommandIndex { get; set; }

        /// <summary>
        /// The stdout/stderr delta that was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaShellCallOutputDelta Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseShellCallOutputContentDeltaStreamingEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number of the event that was emitted.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that was updated.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that was updated.
        /// </param>
        /// <param name="commandIndex">
        /// The index of the shell command that produced output.
        /// </param>
        /// <param name="delta">
        /// The stdout/stderr delta that was emitted.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event, always `response.shell_call_output_content.delta`.<br/>
        /// Default Value: response.shell_call_output_content.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseShellCallOutputContentDeltaStreamingEvent(
            int sequenceNumber,
            string itemId,
            int outputIndex,
            int commandIndex,
            global::tryAGI.OpenAI.BetaShellCallOutputDelta delta,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType type = global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Agent = agent;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.CommandIndex = commandIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseShellCallOutputContentDeltaStreamingEvent" /> class.
        /// </summary>
        public BetaResponseShellCallOutputContentDeltaStreamingEvent()
        {
        }

    }
}