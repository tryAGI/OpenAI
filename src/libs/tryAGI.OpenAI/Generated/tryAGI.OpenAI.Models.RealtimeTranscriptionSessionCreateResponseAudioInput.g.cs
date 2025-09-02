
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseAudioInput
    {
        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_reduction")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReduction? NoiseReduction { get; set; }

        /// <summary>
        /// Configuration of the transcription model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseAudioInputTranscription? Transcription { get; set; }

        /// <summary>
        /// Configuration for turn detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseAudioInputTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseAudioInput" /> class.
        /// </summary>
        /// <param name="format">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="noiseReduction">
        /// Configuration for input audio noise reduction.
        /// </param>
        /// <param name="transcription">
        /// Configuration of the transcription model.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseAudioInput(
            string? format,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReduction? noiseReduction,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseAudioInputTranscription? transcription,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseAudioInputTurnDetection? turnDetection)
        {
            this.Format = format;
            this.NoiseReduction = noiseReduction;
            this.Transcription = transcription;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseAudioInput" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseAudioInput()
        {
        }
    }
}