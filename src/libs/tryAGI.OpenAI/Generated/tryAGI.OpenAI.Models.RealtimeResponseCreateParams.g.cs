
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a new Realtime response with these parameters
    /// </summary>
    public sealed partial class RealtimeResponseCreateParams
    {
        /// <summary>
        /// Controls which conversation the response is added to. Currently supports<br/>
        /// `auto` and `none`, with `auto` as the default value. The `auto` value<br/>
        /// means that the contents of the response will be added to the default<br/>
        /// conversation. Set this to `none` to create an out-of-band response which <br/>
        /// will not add items to default conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? Conversation { get; set; }

        /// <summary>
        /// Input items to include in the prompt for the model. Using this field<br/>
        /// creates a new context for this Response instead of using the default<br/>
        /// conversation. An empty array `[]` will clear the context for this Response.<br/>
        /// Note that this can include references to items from the default conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? Input { get; set; }

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
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>))]
        public global::tryAGI.OpenAI.AnyOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsModalitie>? Modalities { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsOutputAudioFormatJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Reference to a prompt template and its variables. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/text?api-mode=responses#reusable-prompts).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::tryAGI.OpenAI.Prompt2? Prompt { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? ToolChoice { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsTool>? Tools { get; set; }

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
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParams" /> class.
        /// </summary>
        /// <param name="conversation">
        /// Controls which conversation the response is added to. Currently supports<br/>
        /// `auto` and `none`, with `auto` as the default value. The `auto` value<br/>
        /// means that the contents of the response will be added to the default<br/>
        /// conversation. Set this to `none` to create an out-of-band response which <br/>
        /// will not add items to default conversation.
        /// </param>
        /// <param name="input">
        /// Input items to include in the prompt for the model. Using this field<br/>
        /// creates a new context for this Response instead of using the default<br/>
        /// conversation. An empty array `[]` will clear the context for this Response.<br/>
        /// Note that this can include references to items from the default conversation.
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
        /// <param name="maxOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="prompt">
        /// Reference to a prompt template and its variables. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/text?api-mode=responses#reusable-prompts).
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="voice">
        /// Example: ash
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseCreateParams(
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? conversation,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? input,
            string? instructions,
            global::tryAGI.OpenAI.AnyOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>? maxOutputTokens,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsModalitie>? modalities,
            global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputAudioFormat? outputAudioFormat,
            global::tryAGI.OpenAI.Prompt2? prompt,
            double? temperature,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? toolChoice,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsTool>? tools,
            global::tryAGI.OpenAI.VoiceIdsShared? voice)
        {
            this.Conversation = conversation;
            this.Input = input;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.Metadata = metadata;
            this.Modalities = modalities;
            this.OutputAudioFormat = outputAudioFormat;
            this.Prompt = prompt;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParams" /> class.
        /// </summary>
        public RealtimeResponseCreateParams()
        {
        }
    }
}