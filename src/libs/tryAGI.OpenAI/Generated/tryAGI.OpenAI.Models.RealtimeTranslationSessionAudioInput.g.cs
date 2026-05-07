
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranslationSessionAudioInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription2? Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_reduction")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction2? NoiseReduction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionAudioInput" /> class.
        /// </summary>
        /// <param name="transcription"></param>
        /// <param name="noiseReduction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionAudioInput(
            global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputTranscription2? transcription,
            global::tryAGI.OpenAI.RealtimeTranslationSessionAudioInputNoiseReduction2? noiseReduction)
        {
            this.Transcription = transcription;
            this.NoiseReduction = noiseReduction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionAudioInput" /> class.
        /// </summary>
        public RealtimeTranslationSessionAudioInput()
        {
        }
    }
}