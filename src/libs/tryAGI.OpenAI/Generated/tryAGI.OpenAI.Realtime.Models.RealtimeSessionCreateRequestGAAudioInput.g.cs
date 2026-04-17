
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestGAAudioInput
    {
        /// <summary>
        /// The format of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? Format { get; set; }

        /// <summary>
        /// Configuration for input audio transcription, defaults to off and can be set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs asynchronously through [the /audio/transcriptions endpoint](/docs/api-reference/audio/createTranscription) and should be treated as guidance of input audio content rather than precisely what the model heard. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::tryAGI.OpenAI.Realtime.AudioTranscription? Transcription { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_reduction")]
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? NoiseReduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGAAudioInput" /> class.
        /// </summary>
        /// <param name="format">
        /// The format of the input audio.
        /// </param>
        /// <param name="transcription">
        /// Configuration for input audio transcription, defaults to off and can be set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs asynchronously through [the /audio/transcriptions endpoint](/docs/api-reference/audio/createTranscription) and should be treated as guidance of input audio content rather than precisely what the model heard. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </param>
        /// <param name="noiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="turnDetection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestGAAudioInput(
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormats? format,
            global::tryAGI.OpenAI.Realtime.AudioTranscription? transcription,
            global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudioInputNoiseReduction? noiseReduction,
            global::tryAGI.OpenAI.Realtime.RealtimeTurnDetectionRealtimeTurnDetection1? turnDetection)
        {
            this.Format = format;
            this.Transcription = transcription;
            this.NoiseReduction = noiseReduction;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGAAudioInput" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestGAAudioInput()
        {
        }
    }
}