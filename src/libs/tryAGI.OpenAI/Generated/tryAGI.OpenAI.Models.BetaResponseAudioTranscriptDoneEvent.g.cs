
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the full audio transcript is completed.
    /// </summary>
    public sealed partial class BetaResponseAudioTranscriptDoneEvent
    {
        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the event. Always `response.audio.transcript.done`.
        /// </summary>
        /// <default>"response.audio.transcript.done"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "response.audio.transcript.done";

        /// <summary>
        /// The sequence number of this event.
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
        /// Initializes a new instance of the <see cref="BetaResponseAudioTranscriptDoneEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.audio.transcript.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseAudioTranscriptDoneEvent(
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            string type = "response.audio.transcript.done")
        {
            this.Agent = agent;
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseAudioTranscriptDoneEvent" /> class.
        /// </summary>
        public BetaResponseAudioTranscriptDoneEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaResponseAudioTranscriptDoneEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaResponseAudioTranscriptDoneEvent FromSequenceNumber(int sequenceNumber)
        {
            return new BetaResponseAudioTranscriptDoneEvent
            {
                SequenceNumber = sequenceNumber,
            };
        }

    }
}