
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseGAAudioInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? Format { get; set; }

        /// <summary>
        /// Configuration of the transcription model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::tryAGI.OpenAI.Realtime.AudioTranscriptionResponse? Transcription { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_reduction")]
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? NoiseReduction { get; set; }

        /// <summary>
        /// Configuration for turn detection. For `gpt-realtime-whisper`, this must be `null`; VAD is not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection2? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseGAAudioInput" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="transcription">
        /// Configuration of the transcription model.
        /// </param>
        /// <param name="noiseReduction">
        /// Configuration for input audio noise reduction.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. For `gpt-realtime-whisper`, this must be `null`; VAD is not supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseGAAudioInput(
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? format,
            global::tryAGI.OpenAI.Realtime.AudioTranscriptionResponse? transcription,
            global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction? noiseReduction,
            global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateResponseGAAudioInputTurnDetection2? turnDetection)
        {
            this.Format = format;
            this.Transcription = transcription;
            this.NoiseReduction = noiseReduction;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseGAAudioInput" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseGAAudioInput()
        {
        }
    }
}