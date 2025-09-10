
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A new Realtime session configuration, with an ephemeral key. Default TTL<br/>
    /// for keys is one minute.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseGA
    {
        /// <summary>
        /// Configuration for input and output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio? Audio { get; set; }

        /// <summary>
        /// Ephemeral key returned by the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAClientSecret ClientSecret { get; set; }

        /// <summary>
        /// Additional fields to include in server outputs.<br/>
        /// `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? Include { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>))]
        public global::tryAGI.OpenAI.AnyOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// The Realtime model used for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>? Model { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. It defaults to `["audio"]`, indicating<br/>
        /// that the model will respond with audio plus a transcript. `["text"]` can be used to make<br/>
        /// the model respond with text only. It is not possible to request both `text` and `audio` at the same time.<br/>
        /// Default Value: [audio]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? OutputModalities { get; set; }

        /// <summary>
        /// Reference to a prompt template and its variables. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/text?api-mode=responses#reusable-prompts).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::tryAGI.OpenAI.Prompt2? Prompt { get; set; }

        /// <summary>
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? ToolChoice { get; set; }

        /// <summary>
        /// Tools available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? Tools { get; set; }

        /// <summary>
        /// Realtime API can write session traces to the [Traces Dashboard](/logs?api=traces). Set to null to disable tracing. Once<br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the<br/>
        /// workflow name, group id, and metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingEnum2>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingEnum2>? Tracing { get; set; }

        /// <summary>
        /// Controls how the realtime conversation is truncated prior to model inference.<br/>
        /// The default is `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTruncationJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTruncation? Truncation { get; set; }

        /// <summary>
        /// The type of session to create. Always `realtime` for the Realtime API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseGATypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseGA" /> class.
        /// </summary>
        /// <param name="audio">
        /// Configuration for input and output audio.
        /// </param>
        /// <param name="clientSecret">
        /// Ephemeral key returned by the API.
        /// </param>
        /// <param name="include">
        /// Additional fields to include in server outputs.<br/>
        /// `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. "be extremely succinct", "act friendly", "here are examples of good responses") and on audio behavior (e.g. "talk quickly", "inject emotion into your voice", "laugh frequently"). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
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
        /// <param name="outputModalities">
        /// The set of modalities the model can respond with. It defaults to `["audio"]`, indicating<br/>
        /// that the model will respond with audio plus a transcript. `["text"]` can be used to make<br/>
        /// the model respond with text only. It is not possible to request both `text` and `audio` at the same time.<br/>
        /// Default Value: [audio]
        /// </param>
        /// <param name="prompt">
        /// Reference to a prompt template and its variables. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/text?api-mode=responses#reusable-prompts).
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="tools">
        /// Tools available to the model.
        /// </param>
        /// <param name="tracing">
        /// Realtime API can write session traces to the [Traces Dashboard](/logs?api=traces). Set to null to disable tracing. Once<br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the<br/>
        /// workflow name, group id, and metadata.
        /// </param>
        /// <param name="truncation">
        /// Controls how the realtime conversation is truncated prior to model inference.<br/>
        /// The default is `auto`.
        /// </param>
        /// <param name="type">
        /// The type of session to create. Always `realtime` for the Realtime API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseGA(
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAClientSecret clientSecret,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAAudio? audio,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAIncludeItem>? include,
            string? instructions,
            global::tryAGI.OpenAI.AnyOf<int?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAMaxOutputTokens?>? maxOutputTokens,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAModel?>? model,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAOutputModalitie>? outputModalities,
            global::tryAGI.OpenAI.Prompt2? prompt,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? toolChoice,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? tools,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingEnum?, global::tryAGI.OpenAI.RealtimeSessionCreateResponseGATracingEnum2>? tracing,
            global::tryAGI.OpenAI.RealtimeTruncation? truncation,
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseGAType type)
        {
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Audio = audio;
            this.Include = include;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.Model = model;
            this.OutputModalities = outputModalities;
            this.Prompt = prompt;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.Tracing = tracing;
            this.Truncation = truncation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseGA" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseGA()
        {
        }
    }
}