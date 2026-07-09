
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when there is a partial transcript of audio.
    /// </summary>
    public sealed partial class BetaResponseAudioTranscriptDeltaEvent
    {
        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the event. Always `response.audio.transcript.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType Type { get; set; }

        /// <summary>
        /// The partial transcript of the audio response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaResponseAudioTranscriptDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// The partial transcript of the audio response.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.audio.transcript.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseAudioTranscriptDeltaEvent(
            string delta,
            int sequenceNumber,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType type)
        {
            this.Agent = agent;
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseAudioTranscriptDeltaEvent" /> class.
        /// </summary>
        public BetaResponseAudioTranscriptDeltaEvent()
        {
        }

    }
}