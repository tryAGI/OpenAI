
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Realtime session object configuration.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestGA
    {
        /// <summary>
        /// The type of session to create. Always `realtime` for the Realtime API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeSessionCreateRequestGATypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAType Type { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. It defaults to `["audio"]`, indicating<br/>
        /// that the model will respond with audio plus a transcript. `["text"]` can be used to make<br/>
        /// the model respond with text only. It is not possible to request both `text` and `audio` at the same time.<br/>
        /// Default Value: [audio]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie>? OutputModalities { get; set; }

        /// <summary>
        /// The Realtime model used for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel?>))]
        public global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel?>? Model { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. "be extremely succinct", "act friendly", "here are examples of good responses") and on audio behavior (e.g. "talk quickly", "inject emotion into your voice", "laugh frequently"). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Configuration for input and output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudio? Audio { get; set; }

        /// <summary>
        /// Additional fields to include in server outputs.<br/>
        /// `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem>? Include { get; set; }

        /// <summary>
        /// Realtime API can write session traces to the [Traces Dashboard](https://platform.openai.com/logs?api=traces). Set to null to disable tracing. Once<br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the<br/>
        /// workflow name, group id, and metadata.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2>))]
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2>? Tracing { get; set; }

        /// <summary>
        /// Tools available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>))]
        public global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>? ToolChoice { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens?>))]
        public global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// When the number of tokens in a conversation exceeds the model's input token limit, the conversation be truncated, meaning messages (starting from the oldest) will not be included in the model's context. A 32k context model with 4,096 max output tokens can only include 28,224 tokens in the context before truncation occurs.<br/>
        /// Clients can configure truncation behavior to truncate with a lower max token limit, which is an effective way to control token usage and cost.<br/>
        /// Truncation will reduce the number of cached tokens on the next turn (busting the cache), since messages are dropped from the beginning of the context. However, clients can also configure truncation to retain messages up to a fraction of the maximum context size, which will reduce the need for future truncations and thus improve the cache rate.<br/>
        /// Truncation can be disabled entirely, which means the server will never truncate but would instead return an error if the conversation exceeds the model's input token limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTruncationJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeTruncation? Truncation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::tryAGI.OpenAI.Realtime.PromptVariant1? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGA" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of session to create. Always `realtime` for the Realtime API.
        /// </param>
        /// <param name="outputModalities">
        /// The set of modalities the model can respond with. It defaults to `["audio"]`, indicating<br/>
        /// that the model will respond with audio plus a transcript. `["text"]` can be used to make<br/>
        /// the model respond with text only. It is not possible to request both `text` and `audio` at the same time.<br/>
        /// Default Value: [audio]
        /// </param>
        /// <param name="model">
        /// The Realtime model used for this session.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. "be extremely succinct", "act friendly", "here are examples of good responses") and on audio behavior (e.g. "talk quickly", "inject emotion into your voice", "laugh frequently"). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
        /// </param>
        /// <param name="audio">
        /// Configuration for input and output audio.
        /// </param>
        /// <param name="include">
        /// Additional fields to include in server outputs.<br/>
        /// `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </param>
        /// <param name="tracing">
        /// Realtime API can write session traces to the [Traces Dashboard](https://platform.openai.com/logs?api=traces). Set to null to disable tracing. Once<br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the<br/>
        /// workflow name, group id, and metadata.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tools">
        /// Tools available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="truncation">
        /// When the number of tokens in a conversation exceeds the model's input token limit, the conversation be truncated, meaning messages (starting from the oldest) will not be included in the model's context. A 32k context model with 4,096 max output tokens can only include 28,224 tokens in the context before truncation occurs.<br/>
        /// Clients can configure truncation behavior to truncate with a lower max token limit, which is an effective way to control token usage and cost.<br/>
        /// Truncation will reduce the number of cached tokens on the next turn (busting the cache), since messages are dropped from the beginning of the context. However, clients can also configure truncation to retain messages up to a fraction of the maximum context size, which will reduce the need for future truncations and thus improve the cache rate.<br/>
        /// Truncation can be disabled entirely, which means the server will never truncate but would instead return an error if the conversation exceeds the model's input token limit.
        /// </param>
        /// <param name="prompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestGA(
            global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAType type,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAOutputModalitie>? outputModalities,
            global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAModel?>? model,
            string? instructions,
            global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAAudio? audio,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAIncludeItem>? include,
            global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGATracingEnum2>? tracing,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.RealtimeFunctionTool, global::tryAGI.OpenAI.Realtime.MCPTool>>? tools,
            global::tryAGI.OpenAI.Realtime.OneOf<global::tryAGI.OpenAI.Realtime.ToolChoiceOptions?, global::tryAGI.OpenAI.Realtime.ToolChoiceFunction, global::tryAGI.OpenAI.Realtime.ToolChoiceMCP>? toolChoice,
            global::tryAGI.OpenAI.Realtime.OneOf<int?, global::tryAGI.OpenAI.Realtime.RealtimeSessionCreateRequestGAMaxOutputTokens?>? maxOutputTokens,
            global::tryAGI.OpenAI.Realtime.RealtimeTruncation? truncation,
            global::tryAGI.OpenAI.Realtime.PromptVariant1? prompt)
        {
            this.Type = type;
            this.OutputModalities = outputModalities;
            this.Model = model;
            this.Instructions = instructions;
            this.Audio = audio;
            this.Include = include;
            this.Tracing = tracing;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.MaxOutputTokens = maxOutputTokens;
            this.Truncation = truncation;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGA" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestGA()
        {
        }
    }
}