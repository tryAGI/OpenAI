
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A streaming event that indicated a shell command was incrementally updated.
    /// </summary>
    public sealed partial class BetaResponseShellCallCommandDeltaStreamingEvent
    {
        /// <summary>
        /// The type of the event, always `response.shell_call_command.delta`.<br/>
        /// Default Value: response.shell_call_command.delta
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType.ResponseShellCallCommandDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDeltaStreamingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType Type { get; set; } = global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType.ResponseShellCallCommandDelta;

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
        /// The index of the output item that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the shell command that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommandIndex { get; set; }

        /// <summary>
        /// The shell command delta that was appended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// An obfuscation string that was added to pad the event payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obfuscation")]
        public string? Obfuscation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseShellCallCommandDeltaStreamingEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number of the event that was emitted.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that was updated.
        /// </param>
        /// <param name="commandIndex">
        /// The index of the shell command that was updated.
        /// </param>
        /// <param name="delta">
        /// The shell command delta that was appended.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="obfuscation">
        /// An obfuscation string that was added to pad the event payload.
        /// </param>
        /// <param name="type">
        /// The type of the event, always `response.shell_call_command.delta`.<br/>
        /// Default Value: response.shell_call_command.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseShellCallCommandDeltaStreamingEvent(
            int sequenceNumber,
            int outputIndex,
            int commandIndex,
            string delta,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            string? obfuscation,
            global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType type = global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType.ResponseShellCallCommandDelta)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Agent = agent;
            this.OutputIndex = outputIndex;
            this.CommandIndex = commandIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Obfuscation = obfuscation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseShellCallCommandDeltaStreamingEvent" /> class.
        /// </summary>
        public BetaResponseShellCallCommandDeltaStreamingEvent()
        {
        }

    }
}