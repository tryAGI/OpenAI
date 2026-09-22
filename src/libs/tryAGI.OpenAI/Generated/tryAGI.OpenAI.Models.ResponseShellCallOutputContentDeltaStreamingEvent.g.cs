
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A streaming event that indicated shell call output was incrementally added.
    /// </summary>
    public sealed partial class ResponseShellCallOutputContentDeltaStreamingEvent
    {
        /// <summary>
        /// The type of the event, always `response.shell_call_output_content.delta`.<br/>
        /// Default Value: response.shell_call_output_content.delta
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDeltaStreamingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType Type { get; set; } = global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta;

        /// <summary>
        /// The sequence number of the event that was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

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
        public required global::tryAGI.OpenAI.ShellCallOutputDelta Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseShellCallOutputContentDeltaStreamingEvent" /> class.
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
        /// <param name="type">
        /// The type of the event, always `response.shell_call_output_content.delta`.<br/>
        /// Default Value: response.shell_call_output_content.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseShellCallOutputContentDeltaStreamingEvent(
            int sequenceNumber,
            string itemId,
            int outputIndex,
            int commandIndex,
            global::tryAGI.OpenAI.ShellCallOutputDelta delta,
            global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType type = global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType.ResponseShellCallOutputContentDelta)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.CommandIndex = commandIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseShellCallOutputContentDeltaStreamingEvent" /> class.
        /// </summary>
        public ResponseShellCallOutputContentDeltaStreamingEvent()
        {
        }

    }
}