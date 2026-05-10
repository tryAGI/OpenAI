
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranslationSessionUpdateRequestAudioInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputTranscription2? Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_reduction")]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputNoiseReduction2? NoiseReduction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionUpdateRequestAudioInput" /> class.
        /// </summary>
        /// <param name="transcription"></param>
        /// <param name="noiseReduction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionUpdateRequestAudioInput(
            global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputTranscription2? transcription,
            global::tryAGI.OpenAI.RealtimeTranslationSessionUpdateRequestAudioInputNoiseReduction2? noiseReduction)
        {
            this.Transcription = transcription;
            this.NoiseReduction = noiseReduction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionUpdateRequestAudioInput" /> class.
        /// </summary>
        public RealtimeTranslationSessionUpdateRequestAudioInput()
        {
        }

    }
}