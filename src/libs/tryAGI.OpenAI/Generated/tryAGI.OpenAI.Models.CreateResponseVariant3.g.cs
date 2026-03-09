
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponseVariant3
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InputParamJsonConverter))]
        public global::tryAGI.OpenAI.InputParam? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? Include { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::tryAGI.OpenAI.ResponseStreamOptionsVariant1? StreamOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::tryAGI.OpenAI.ConversationParam? Conversation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>? ContextManagement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
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
        /// <param name="stream"></param>
        /// <param name="streamOptions"></param>
        /// <param name="conversation"></param>
        /// <param name="contextManagement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseVariant3(
            global::tryAGI.OpenAI.InputParam? input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? include,
            bool? parallelToolCalls,
            bool? store,
            string? instructions,
            bool? stream,
            global::tryAGI.OpenAI.ResponseStreamOptionsVariant1? streamOptions,
            global::tryAGI.OpenAI.ConversationParam? conversation,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>? contextManagement)
        {
            this.Input = input;
            this.Include = include;
            this.ParallelToolCalls = parallelToolCalls;
            this.Store = store;
            this.Instructions = instructions;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Conversation = conversation;
            this.ContextManagement = contextManagement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
        public CreateResponseVariant3()
        {
        }
    }
}