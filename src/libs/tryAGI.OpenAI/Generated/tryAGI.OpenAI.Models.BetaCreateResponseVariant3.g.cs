
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCreateResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation2? Truncation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.BetaReasoning? Reasoning { get; set; }

        /// <summary>
        /// Text, image, or file inputs to the model, used to generate a response.<br/>
        /// Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Image inputs](/docs/guides/images)<br/>
        /// - [File inputs](/docs/guides/pdf-files)<br/>
        /// - [Conversation state](/docs/guides/conversation-state)<br/>
        /// - [Function calling](/docs/guides/function-calling)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInputParamJsonConverter))]
        public global::tryAGI.OpenAI.BetaInputParam? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public global::tryAGI.OpenAI.BetaModerationParam? Moderation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1? StreamOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::tryAGI.OpenAI.BetaConversationParam? Conversation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>? ContextManagement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_agent")]
        public global::tryAGI.OpenAI.BetaMultiAgentParam? MultiAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateResponseVariant3" /> class.
        /// </summary>
        /// <param name="reasoning"></param>
        /// <param name="input">
        /// Text, image, or file inputs to the model, used to generate a response.<br/>
        /// Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Image inputs](/docs/guides/images)<br/>
        /// - [File inputs](/docs/guides/pdf-files)<br/>
        /// - [Conversation state](/docs/guides/conversation-state)<br/>
        /// - [Function calling](/docs/guides/function-calling)
        /// </param>
        /// <param name="include"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="store"></param>
        /// <param name="instructions"></param>
        /// <param name="moderation"></param>
        /// <param name="stream"></param>
        /// <param name="streamOptions"></param>
        /// <param name="conversation"></param>
        /// <param name="contextManagement"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="multiAgent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateResponseVariant3(
            global::tryAGI.OpenAI.BetaReasoning? reasoning,
            global::tryAGI.OpenAI.BetaInputParam? input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? include,
            bool? parallelToolCalls,
            bool? store,
            string? instructions,
            global::tryAGI.OpenAI.BetaModerationParam? moderation,
            bool? stream,
            global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1? streamOptions,
            global::tryAGI.OpenAI.BetaConversationParam? conversation,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>? contextManagement,
            int? maxOutputTokens,
            global::tryAGI.OpenAI.BetaMultiAgentParam? multiAgent)
        {
            this.Reasoning = reasoning;
            this.Input = input;
            this.Include = include;
            this.ParallelToolCalls = parallelToolCalls;
            this.Store = store;
            this.Instructions = instructions;
            this.Moderation = moderation;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Conversation = conversation;
            this.ContextManagement = contextManagement;
            this.MaxOutputTokens = maxOutputTokens;
            this.MultiAgent = multiAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateResponseVariant3" /> class.
        /// </summary>
        public BetaCreateResponseVariant3()
        {
        }

    }
}