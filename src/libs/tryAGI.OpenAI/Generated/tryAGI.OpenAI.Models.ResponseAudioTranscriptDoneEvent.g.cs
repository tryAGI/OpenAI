
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the full audio transcript is completed.
    /// </summary>
    public sealed partial class ResponseAudioTranscriptDoneEvent
    {
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
        /// Initializes a new instance of the <see cref="ResponseAudioTranscriptDoneEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.audio.transcript.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAudioTranscriptDoneEvent(
            int sequenceNumber,
            string type = "response.audio.transcript.done")
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioTranscriptDoneEvent" /> class.
        /// </summary>
        public ResponseAudioTranscriptDoneEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseAudioTranscriptDoneEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseAudioTranscriptDoneEvent FromSequenceNumber(int sequenceNumber)
        {
            return new ResponseAudioTranscriptDoneEvent
            {
                SequenceNumber = sequenceNumber,
            };
        }

    }
}