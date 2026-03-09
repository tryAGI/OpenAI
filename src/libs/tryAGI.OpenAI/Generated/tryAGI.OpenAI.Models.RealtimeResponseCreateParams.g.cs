
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
        /// The set of modalities the model used to respond, currently the only possible values are<br/>
        /// `[\"audio\"]`, `[\"text\"]`. Audio output always include a text transcript. Setting the<br/>
        /// output to mode `text` will disable audio output from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? OutputModalities { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. "be extremely succinct", "act friendly", "here are examples of good responses") and on audio behavior (e.g. "talk quickly", "inject emotion into your voice", "laugh frequently"). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Configuration for audio input and output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio? Audio { get; set; }

        /// <summary>
        /// Tools available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools. Provide one of the string modes or force a specific<br/>
        /// function/MCP tool.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? ToolChoice { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>))]
        public global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>? MaxOutputTokens { get; set; }

        /// <summary>
        /// Controls which conversation the response is added to. Currently supports<br/>
        /// `auto` and `none`, with `auto` as the default value. The `auto` value<br/>
        /// means that the contents of the response will be added to the default<br/>
        /// conversation. Set this to `none` to create an out-of-band response which<br/>
        /// will not add items to default conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>))]
        public global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? Conversation { get; set; }

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
        /// Note that this can include references to items that previously appeared in the session<br/>
        /// using their id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParams" /> class.
        /// </summary>
        /// <param name="outputModalities">
        /// The set of modalities the model used to respond, currently the only possible values are<br/>
        /// `[\"audio\"]`, `[\"text\"]`. Audio output always include a text transcript. Setting the<br/>
        /// output to mode `text` will disable audio output from the model.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. "be extremely succinct", "act friendly", "here are examples of good responses") and on audio behavior (e.g. "talk quickly", "inject emotion into your voice", "laugh frequently"). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
        /// </param>
        /// <param name="audio">
        /// Configuration for audio input and output.
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
        /// <param name="conversation">
        /// Controls which conversation the response is added to. Currently supports<br/>
        /// `auto` and `none`, with `auto` as the default value. The `auto` value<br/>
        /// means that the contents of the response will be added to the default<br/>
        /// conversation. Set this to `none` to create an out-of-band response which<br/>
        /// will not add items to default conversation.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="prompt"></param>
        /// <param name="input">
        /// Input items to include in the prompt for the model. Using this field<br/>
        /// creates a new context for this Response instead of using the default<br/>
        /// conversation. An empty array `[]` will clear the context for this Response.<br/>
        /// Note that this can include references to items that previously appeared in the session<br/>
        /// using their id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseCreateParams(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeResponseCreateParamsOutputModalitie>? outputModalities,
            string? instructions,
            global::tryAGI.OpenAI.RealtimeResponseCreateParamsAudio? audio,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeFunctionTool, global::tryAGI.OpenAI.MCPTool>>? tools,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? toolChoice,
            global::tryAGI.OpenAI.OneOf<int?, global::tryAGI.OpenAI.RealtimeResponseCreateParamsMaxOutputTokens?>? maxOutputTokens,
            global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.RealtimeResponseCreateParamsConversation?>? conversation,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.PromptVariant1? prompt,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeConversationItem>? input)
        {
            this.OutputModalities = outputModalities;
            this.Instructions = instructions;
            this.Audio = audio;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.MaxOutputTokens = maxOutputTokens;
            this.Conversation = conversation;
            this.Metadata = metadata;
            this.Prompt = prompt;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParams" /> class.
        /// </summary>
        public RealtimeResponseCreateParams()
        {
        }
    }
}