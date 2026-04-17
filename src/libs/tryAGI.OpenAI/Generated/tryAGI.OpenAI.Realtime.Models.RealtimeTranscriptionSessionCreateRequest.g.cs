
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Realtime transcription session object configuration.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateRequest
    {
        /// <summary>
        /// Configuration for turn detection. Can be set to `null` to turn off. Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_noise_reduction")]
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? InputAudioNoiseReduction { get; set; }

        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestInputAudioFormatJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? InputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio transcription. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_transcription")]
        public global::tryAGI.OpenAI.Realtime.AudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// The set of items to include in the transcription. Current available items are:<br/>
        /// `item.input_audio_transcription.logprobs`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem>? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequest" /> class.
        /// </summary>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to `null` to turn off. Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.
        /// </param>
        /// <param name="inputAudioNoiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </param>
        /// <param name="include">
        /// The set of items to include in the transcription. Current available items are:<br/>
        /// `item.input_audio_transcription.logprobs`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateRequest(
            global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestTurnDetection? turnDetection,
            global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction,
            global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? inputAudioFormat,
            global::tryAGI.OpenAI.Realtime.AudioTranscription? inputAudioTranscription,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestIncludeItem>? include)
        {
            this.TurnDetection = turnDetection;
            this.InputAudioNoiseReduction = inputAudioNoiseReduction;
            this.InputAudioFormat = inputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequest" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateRequest()
        {
        }
    }
}