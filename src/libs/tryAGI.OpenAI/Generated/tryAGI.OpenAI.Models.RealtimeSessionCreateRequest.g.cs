
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Realtime session object configuration.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequest
    {
        /// <summary>
        /// Configuration options for the generated client secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret? ClientSecret { get; set; }

        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestInputAudioFormatJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioFormat? InputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_noise_reduction")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioNoiseReduction? InputAudioNoiseReduction { get; set; }

        /// <summary>
        /// Configuration for input audio transcription, defaults to off and can be set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs asynchronously through [the /audio/transcriptions endpoint](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as guidance of input audio content rather than precisely what the model heard. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_transcription")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. "be extremely succinct", "act friendly", "here are examples of good responses") and on audio behavior (e.g. "talk quickly", "inject emotion into your voice", "laugh frequently"). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_response_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>))]
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? MaxResponseOutputTokens { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? Modalities { get; set; }

        /// <summary>
        /// The Realtime model used for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestModelJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestModel? Model { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
        /// Default Value: pcm16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestOutputAudioFormatJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestOutputAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// The speed of the model's spoken response. 1.0 is the default speed. 0.25 is<br/>
        /// the minimum speed. 1.5 is the maximum speed. This value can only be changed<br/>
        /// in between model turns, not while a response is in progress.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. For audio models a temperature of 0.8 is highly recommended for best performance.<br/>
        /// Default Value: 0.8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or<br/>
        /// specify a function.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? Tools { get; set; }

        /// <summary>
        /// Configuration options for tracing. Set to null to disable tracing. Once <br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the <br/>
        /// workflow name, group id, and metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>? Tracing { get; set; }

        /// <summary>
        /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
        /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
        /// Semantic VAD is more advanced and uses a turn detection model (in conjuction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Example: ash
        /// </summary>
        /// <example>ash</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter))]
        public global::tryAGI.OpenAI.VoiceIdsShared? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequest" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// Configuration options for the generated client secret.
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="inputAudioNoiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription, defaults to off and can be set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs asynchronously through [the /audio/transcriptions endpoint](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as guidance of input audio content rather than precisely what the model heard. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. "be extremely succinct", "act friendly", "here are examples of good responses") and on audio behavior (e.g. "talk quickly", "inject emotion into your voice", "laugh frequently"). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
        /// </param>
        /// <param name="maxResponseOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="model">
        /// The Realtime model used for this session.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="speed">
        /// The speed of the model's spoken response. 1.0 is the default speed. 0.25 is<br/>
        /// the minimum speed. 1.5 is the maximum speed. This value can only be changed<br/>
        /// in between model turns, not while a response is in progress.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. For audio models a temperature of 0.8 is highly recommended for best performance.<br/>
        /// Default Value: 0.8
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or<br/>
        /// specify a function.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="tracing">
        /// Configuration options for tracing. Set to null to disable tracing. Once <br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the <br/>
        /// workflow name, group id, and metadata.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
        /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
        /// Semantic VAD is more advanced and uses a turn detection model (in conjuction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
        /// </param>
        /// <param name="voice">
        /// Example: ash
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequest(
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecret? clientSecret,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioFormat? inputAudioFormat,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestInputAudioTranscription? inputAudioTranscription,
            string? instructions,
            global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? maxResponseOutputTokens,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestModalitie>? modalities,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestModel? model,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestOutputAudioFormat? outputAudioFormat,
            double? speed,
            double? temperature,
            string? toolChoice,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTool>? tools,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateRequestTracingEnum2>? tracing,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestTurnDetection? turnDetection,
            global::tryAGI.OpenAI.VoiceIdsShared? voice)
        {
            this.ClientSecret = clientSecret;
            this.InputAudioFormat = inputAudioFormat;
            this.InputAudioNoiseReduction = inputAudioNoiseReduction;
            this.InputAudioTranscription = inputAudioTranscription;
            this.Instructions = instructions;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
            this.Modalities = modalities;
            this.Model = model;
            this.OutputAudioFormat = outputAudioFormat;
            this.Speed = speed;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.Tracing = tracing;
            this.TurnDetection = turnDetection;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequest" /> class.
        /// </summary>
        public RealtimeSessionCreateRequest()
        {
        }
    }
}