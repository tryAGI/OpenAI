
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseAudioInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Format { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_reduction")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? NoiseReduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::tryAGI.OpenAI.AudioTranscription? Transcription { get; set; }

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
        /// <param name="format"></param>
        /// <param name="noiseReduction">
        /// Configuration for input audio noise reduction.
        /// </param>
        /// <param name="transcription"></param>
        /// <param name="turnDetection">
        /// Configuration for turn detection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseAudioInput(
            global::tryAGI.OpenAI.RealtimeAudioFormats? format,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReduction? noiseReduction,
            global::tryAGI.OpenAI.AudioTranscription? transcription,
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