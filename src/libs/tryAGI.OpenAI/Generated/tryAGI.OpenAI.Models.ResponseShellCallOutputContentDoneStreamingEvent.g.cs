
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A streaming event that indicated shell call output was completed.
    /// </summary>
    public sealed partial class ResponseShellCallOutputContentDoneStreamingEvent
    {
        /// <summary>
        /// The type of the event, always `response.shell_call_output_content.done`.<br/>
        /// Default Value: response.shell_call_output_content.done
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType.ResponseShellCallOutputContentDone</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDoneStreamingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType Type { get; set; } = global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType.ResponseShellCallOutputContentDone;

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
        /// The output contents emitted for the shell command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent> Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseShellCallOutputContentDoneStreamingEvent" /> class.
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
        /// <param name="output">
        /// The output contents emitted for the shell command.
        /// </param>
        /// <param name="type">
        /// The type of the event, always `response.shell_call_output_content.done`.<br/>
        /// Default Value: response.shell_call_output_content.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseShellCallOutputContentDoneStreamingEvent(
            int sequenceNumber,
            string itemId,
            int outputIndex,
            int commandIndex,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent> output,
            global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType type = global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType.ResponseShellCallOutputContentDone)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.CommandIndex = commandIndex;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseShellCallOutputContentDoneStreamingEvent" /> class.
        /// </summary>
        public ResponseShellCallOutputContentDoneStreamingEvent()
        {
        }

    }
}