
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
        /// <default>"speech.audio.delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "speech.audio.delta";

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
        /// <param name="audio">
        /// A chunk of Base64-encoded audio data.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `speech.audio.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechAudioDeltaEvent(
            string audio,
            string type = "speech.audio.delta")
        {
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAudioDeltaEvent" /> class.
        /// </summary>
        public SpeechAudioDeltaEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SpeechAudioDeltaEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SpeechAudioDeltaEvent FromAudio(string audio)
        {
            return new SpeechAudioDeltaEvent
            {
                Audio = audio,
            };
        }

    }
}