
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Realtime session object for the beta interface.
    /// </summary>
    public sealed partial class RealtimeSession
    {
        /// <summary>
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type. Always `realtime.session`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionObjectJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionObject? Object { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>? Modalities { get; set; }

        /// <summary>
        /// The Realtime model used for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionModel?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>? Model { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model<br/>
        /// calls. This field allows the client to guide the model on desired<br/>
        /// responses. The model can be instructed on response content and format,<br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good<br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion<br/>
        /// into your voice", "laugh frequently"). The instructions are not<br/>
        /// guaranteed to be followed by the model, but they provide guidance to the<br/>
        /// model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this<br/>
        /// field is not set and are visible in the `session.created` event at the<br/>
        /// start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Voice cannot be changed during the<br/>
        /// session once the model has responded with audio at least once. Current<br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`,<br/>
        /// `shimmer`, and `verse`.<br/>
        /// Example: ash
        /// </summary>
        /// <example>ash</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsSharedJsonConverter))]
        public global::tryAGI.OpenAI.VoiceIdsShared? Voice { get; set; }

        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionInputAudioFormatJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat? InputAudioFormat { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
        /// Default Value: pcm16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionOutputAudioFormatJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_transcription")]
        public global::tryAGI.OpenAI.AudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1? TurnDetection { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_noise_reduction")]
        public global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction? InputAudioNoiseReduction { get; set; }

        /// <summary>
        /// The speed of the model's spoken response. 1.0 is the default speed. 0.25 is<br/>
        /// the minimum speed. 1.5 is the maximum speed. This value can only be changed<br/>
        /// in between model turns, not while a response is in progress.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>? Tracing { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or<br/>
        /// specify a function.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. For audio models a temperature of 0.8 is highly recommended for best performance.<br/>
        /// Default Value: 0.8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_response_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>))]
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>? MaxResponseOutputTokens { get; set; }

        /// <summary>
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::tryAGI.OpenAI.PromptVariant1? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSession" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </param>
        /// <param name="object">
        /// The object type. Always `realtime.session`.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="model">
        /// The Realtime model used for this session.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model<br/>
        /// calls. This field allows the client to guide the model on desired<br/>
        /// responses. The model can be instructed on response content and format,<br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good<br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion<br/>
        /// into your voice", "laugh frequently"). The instructions are not<br/>
        /// guaranteed to be followed by the model, but they provide guidance to the<br/>
        /// model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this<br/>
        /// field is not set and are visible in the `session.created` event at the<br/>
        /// start of the session.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Voice cannot be changed during the<br/>
        /// session once the model has responded with audio at least once. Current<br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`,<br/>
        /// `shimmer`, and `verse`.<br/>
        /// Example: ash
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="inputAudioTranscription"></param>
        /// <param name="turnDetection"></param>
        /// <param name="inputAudioNoiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speed">
        /// The speed of the model's spoken response. 1.0 is the default speed. 0.25 is<br/>
        /// the minimum speed. 1.5 is the maximum speed. This value can only be changed<br/>
        /// in between model turns, not while a response is in progress.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="tracing"></param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or<br/>
        /// specify a function.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. For audio models a temperature of 0.8 is highly recommended for best performance.<br/>
        /// Default Value: 0.8
        /// </param>
        /// <param name="maxResponseOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="expiresAt">
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="include"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSession(
            string? id,
            global::tryAGI.OpenAI.RealtimeSessionObject? @object,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionModalitie>? modalities,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionModel?>? model,
            string? instructions,
            global::tryAGI.OpenAI.VoiceIdsShared? voice,
            global::tryAGI.OpenAI.RealtimeSessionInputAudioFormat? inputAudioFormat,
            global::tryAGI.OpenAI.RealtimeSessionOutputAudioFormat? outputAudioFormat,
            global::tryAGI.OpenAI.AudioTranscription? inputAudioTranscription,
            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1? turnDetection,
            global::tryAGI.OpenAI.RealtimeSessionInputAudioNoiseReduction? inputAudioNoiseReduction,
            double? speed,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum?, global::tryAGI.OpenAI.RealtimeSessionTracingTracingConfigurationEnum2>? tracing,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? tools,
            string? toolChoice,
            double? temperature,
            global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeSessionMaxResponseOutputTokens?>? maxResponseOutputTokens,
            int? expiresAt,
            global::tryAGI.OpenAI.PromptVariant1? prompt,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionIncludeVariant1Item>? include)
        {
            this.Id = id;
            this.Object = @object;
            this.Modalities = modalities;
            this.Model = model;
            this.Instructions = instructions;
            this.Voice = voice;
            this.InputAudioFormat = inputAudioFormat;
            this.OutputAudioFormat = outputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.TurnDetection = turnDetection;
            this.InputAudioNoiseReduction = inputAudioNoiseReduction;
            this.Speed = speed;
            this.Tracing = tracing;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
            this.ExpiresAt = expiresAt;
            this.Prompt = prompt;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSession" /> class.
        /// </summary>
        public RealtimeSession()
        {
        }
    }
}