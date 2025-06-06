
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioTranscriptDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.audio.transcript.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAudioTranscriptDoneEvent(
            global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioTranscriptDoneEvent" /> class.
        /// </summary>
        public ResponseAudioTranscriptDoneEvent()
        {
        }
    }
}