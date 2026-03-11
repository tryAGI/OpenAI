
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the speech synthesis is complete and all audio has been streamed.
    /// </summary>
    public sealed partial class SpeechAudioDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `speech.audio.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SpeechAudioDoneEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.SpeechAudioDoneEventType Type { get; set; }

        /// <summary>
        /// Token usage statistics for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SpeechAudioDoneEventUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAudioDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `speech.audio.done`.
        /// </param>
        /// <param name="usage">
        /// Token usage statistics for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechAudioDoneEvent(
            global::tryAGI.OpenAI.SpeechAudioDoneEventUsage usage,
            global::tryAGI.OpenAI.SpeechAudioDoneEventType type)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAudioDoneEvent" /> class.
        /// </summary>
        public SpeechAudioDoneEvent()
        {
        }
    }
}