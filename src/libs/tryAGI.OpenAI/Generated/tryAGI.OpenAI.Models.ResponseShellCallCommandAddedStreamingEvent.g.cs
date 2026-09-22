
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A streaming event that indicated a shell command was added to a tool call.
    /// </summary>
    public sealed partial class ResponseShellCallCommandAddedStreamingEvent
    {
        /// <summary>
        /// The type of the event, always `response.shell_call_command.added`.<br/>
        /// Default Value: response.shell_call_command.added
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType.ResponseShellCallCommandAdded</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandAddedStreamingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType Type { get; set; } = global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType.ResponseShellCallCommandAdded;

        /// <summary>
        /// The sequence number of the event that was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The index of the output item that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the shell command that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommandIndex { get; set; }

        /// <summary>
        /// The shell command that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseShellCallCommandAddedStreamingEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number of the event that was emitted.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that was updated.
        /// </param>
        /// <param name="commandIndex">
        /// The index of the shell command that was added.
        /// </param>
        /// <param name="command">
        /// The shell command that was added.
        /// </param>
        /// <param name="type">
        /// The type of the event, always `response.shell_call_command.added`.<br/>
        /// Default Value: response.shell_call_command.added
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseShellCallCommandAddedStreamingEvent(
            int sequenceNumber,
            int outputIndex,
            int commandIndex,
            string command,
            global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType type = global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType.ResponseShellCallCommandAdded)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.OutputIndex = outputIndex;
            this.CommandIndex = commandIndex;
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseShellCallCommandAddedStreamingEvent" /> class.
        /// </summary>
        public ResponseShellCallCommandAddedStreamingEvent()
        {
        }

    }
}