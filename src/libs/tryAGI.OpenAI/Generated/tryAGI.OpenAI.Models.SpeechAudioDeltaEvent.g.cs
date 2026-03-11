
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted for each chunk of audio data generated during speech synthesis.
    /// </summary>
    public sealed partial class SpeechAudioDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `speech.audio.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SpeechAudioDeltaEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.SpeechAudioDeltaEventType Type { get; set; }

        /// <summary>
        /// A chunk of Base64-encoded audio data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAudioDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `speech.audio.delta`.
        /// </param>
        /// <param name="audio">
        /// A chunk of Base64-encoded audio data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechAudioDeltaEvent(
            string audio,
            global::tryAGI.OpenAI.SpeechAudioDeltaEventType type)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAudioDeltaEvent" /> class.
        /// </summary>
        public SpeechAudioDeltaEvent()
        {
        }
    }
}