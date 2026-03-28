
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a new Realtime response with these parameters
    /// </summary>
    public sealed partial class RealtimeBetaResponseCreateParams
    {
        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? Modalities { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model <br/>
        /// calls. This field allows the client to guide the model on desired <br/>
        /// responses. The model can be instructed on response content and format, <br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good <br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion <br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed <br/>
        /// to be followed by the model, but they provide guidance to the model on the <br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this <br/>
        /// field is not set and are visible in the `session.created` event at the <br/>
        /// start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Supported built-in voices are<br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, `shimmer`, `verse`,<br/>
        /// `marin`, and `cedar`. You may also provide a custom voice object with an<br/>
        /// `id`, for example `{ "id": "voice_1234" }`. Voice cannot be changed during<br/>
        /// the session once the model has responded with audio at least once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VoiceIdsOrCustomVoiceJsonConverter))]
        public global::tryAGI.OpenAI.VoiceIdsOrCustomVoice? Voice { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaResponseCreateParamsOutputAudioFormatJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>))]
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// Controls which conversation the response is added to. Currently supports<br/>
        /// `auto` and `none`, with `auto` as the default value. The `auto` value<br/>
        /// means that the contents of the response will be added to the default<br/>
        /// conversation. Set this to `none` to create an out-of-band response which <br/>
        /// will not add items to default conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>))]
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>? Conversation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::tryAGI.OpenAI.PromptVariant1? Prompt { get; set; }

        /// <summary>
        /// Input items to include in the prompt for the model. Using this field<br/>
        /// creates a new context for this Response instead of using the default<br/>
        /// conversation. An empty array `[]` will clear the context for this Response.<br/>
        /// Note that this can include references to items from the default conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseCreateParams" /> class.
        /// </summary>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model <br/>
        /// calls. This field allows the client to guide the model on desired <br/>
        /// responses. The model can be instructed on response content and format, <br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good <br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion <br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed <br/>
        /// to be followed by the model, but they provide guidance to the model on the <br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this <br/>
        /// field is not set and are visible in the `session.created` event at the <br/>
        /// start of the session.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Supported built-in voices are<br/>
        /// `alloy`, `ash`, `ballad`, `coral`, `echo`, `sage`, `shimmer`, `verse`,<br/>
        /// `marin`, and `cedar`. You may also provide a custom voice object with an<br/>
        /// `id`, for example `{ "id": "voice_1234" }`. Voice cannot be changed during<br/>
        /// the session once the model has responded with audio at least once.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="conversation">
        /// Controls which conversation the response is added to. Currently supports<br/>
        /// `auto` and `none`, with `auto` as the default value. The `auto` value<br/>
        /// means that the contents of the response will be added to the default<br/>
        /// conversation. Set this to `none` to create an out-of-band response which <br/>
        /// will not add items to default conversation.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="prompt"></param>
        /// <param name="input">
        /// Input items to include in the prompt for the model. Using this field<br/>
        /// creates a new context for this Response instead of using the default<br/>
        /// conversation. An empty array `[]` will clear the context for this Response.<br/>
        /// Note that this can include references to items from the default conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaResponseCreateParams(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsModalitie>? modalities,
            string? instructions,
            global::tryAGI.OpenAI.VoiceIdsOrCustomVoice? voice,
            global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsOutputAudioFormat? outputAudioFormat,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsTool>? tools,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? toolChoice,
            double? temperature,
            global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsMaxOutputTokens?>? maxOutputTokens,
            global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeBetaResponseCreateParamsConversation?>? conversation,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.PromptVariant1? prompt,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? input)
        {
            this.Modalities = modalities;
            this.Instructions = instructions;
            this.Voice = voice;
            this.OutputAudioFormat = outputAudioFormat;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxOutputTokens = maxOutputTokens;
            this.Conversation = conversation;
            this.Metadata = metadata;
            this.Prompt = prompt;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaResponseCreateParams" /> class.
        /// </summary>
        public RealtimeBetaResponseCreateParams()
        {
        }
    }
}