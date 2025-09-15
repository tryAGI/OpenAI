
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateRequestGAAudioInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeAudioFormats? Format { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_reduction")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? NoiseReduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::tryAGI.OpenAI.AudioTranscription? Transcription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public object? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestGAAudioInput" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="noiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </param>
        /// <param name="transcription"></param>
        /// <param name="turnDetection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateRequestGAAudioInput(
            global::tryAGI.OpenAI.RealtimeAudioFormats? format,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudioInputNoiseReduction? noiseReduction,
            global::tryAGI.OpenAI.AudioTranscription? transcription,
            object? turnDetection)
        {
            this.Format = format;
            this.NoiseReduction = noiseReduction;
            this.Transcription = transcription;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestGAAudioInput" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateRequestGAAudioInput()
        {
        }
    }
}