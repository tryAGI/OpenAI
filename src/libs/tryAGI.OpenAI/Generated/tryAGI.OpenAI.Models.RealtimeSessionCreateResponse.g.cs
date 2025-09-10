
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime session configuration object.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponse
    {
        /// <summary>
        /// Configuration for input and output audio for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio? Audio { get; set; }

        /// <summary>
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional fields to include in server outputs.<br/>
        /// - `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? Include { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model<br/>
        /// calls. This field allows the client to guide the model on desired<br/>
        /// responses. The model can be instructed on response content and format,<br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good<br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion<br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed<br/>
        /// to be followed by the model, but they provide guidance to the model on the<br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this<br/>
        /// field is not set and are visible in the `session.created` event at the<br/>
        /// start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>))]
        public global::tryAGI.OpenAI.AnyOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// The Realtime model used for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The object type. Always `realtime.session`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? OutputModalities { get; set; }

        /// <summary>
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or<br/>
        /// specify a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? Tools { get; set; }

        /// <summary>
        /// Configuration options for tracing. Set to null to disable tracing. Once<br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the<br/>
        /// workflow name, group id, and metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>? Tracing { get; set; }

        /// <summary>
        /// Configuration for turn detection. Can be set to `null` to turn off. Server<br/>
        /// VAD means that the model will detect the start and end of speech based on<br/>
        /// audio volume and respond at the end of user speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponse" /> class.
        /// </summary>
        /// <param name="audio">
        /// Configuration for input and output audio for the session.
        /// </param>
        /// <param name="expiresAt">
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </param>
        /// <param name="include">
        /// Additional fields to include in server outputs.<br/>
        /// - `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model<br/>
        /// calls. This field allows the client to guide the model on desired<br/>
        /// responses. The model can be instructed on response content and format,<br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good<br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion<br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed<br/>
        /// to be followed by the model, but they provide guidance to the model on the<br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this<br/>
        /// field is not set and are visible in the `session.created` event at the<br/>
        /// start of the session.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="model">
        /// The Realtime model used for this session.
        /// </param>
        /// <param name="object">
        /// The object type. Always `realtime.session`.
        /// </param>
        /// <param name="outputModalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or<br/>
        /// specify a function.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="tracing">
        /// Configuration options for tracing. Set to null to disable tracing. Once<br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the<br/>
        /// workflow name, group id, and metadata.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to `null` to turn off. Server<br/>
        /// VAD means that the model will detect the start and end of speech based on<br/>
        /// audio volume and respond at the end of user speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponse(
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudio? audio,
            int? expiresAt,
            string? id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseIncludeItem>? include,
            string? instructions,
            global::tryAGI.OpenAI.AnyOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseMaxOutputTokens?>? maxOutputTokens,
            string? model,
            string? @object,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseOutputModalitie>? outputModalities,
            string? toolChoice,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeFunctionTool>? tools,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseTracingEnum2>? tracing,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseTurnDetection? turnDetection)
        {
            this.Audio = audio;
            this.ExpiresAt = expiresAt;
            this.Id = id;
            this.Include = include;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.Model = model;
            this.Object = @object;
            this.OutputModalities = outputModalities;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.Tracing = tracing;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponse" /> class.
        /// </summary>
        public RealtimeSessionCreateResponse()
        {
        }
    }
}