
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseAudioInput
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
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? NoiseReduction { get; set; }

        /// <summary>
        /// Configuration for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTranscription? Transcription { get; set; }

        /// <summary>
        /// Configuration for turn detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudioInput" /> class.
        /// </summary>
        /// <param name="format">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="noiseReduction">
        /// Configuration for input audio noise reduction.
        /// </param>
        /// <param name="transcription">
        /// Configuration for input audio transcription.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseAudioInput(
            string? format,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? noiseReduction,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTranscription? transcription,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputTurnDetection? turnDetection)
        {
            this.Format = format;
            this.NoiseReduction = noiseReduction;
            this.Transcription = transcription;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudioInput" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseAudioInput()
        {
        }
    }
}