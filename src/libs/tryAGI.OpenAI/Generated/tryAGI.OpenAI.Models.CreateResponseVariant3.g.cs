
#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>> Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Includable>? Include { get; set; }

        /// <summary>
        /// Whether to allow the model to run tool calls in parallel.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Whether to store the generated model response for later retrieval via<br/>
        /// API.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format).<br/>
        /// See the [Streaming section below](/docs/api-reference/responses-streaming)<br/>
        /// for more information.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

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
        /// <param name="parallelToolCalls">
        /// Whether to allow the model to run tool calls in parallel.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="store">
        /// Whether to store the generated model response for later retrieval via<br/>
        /// API.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stream">
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format).<br/>
        /// See the [Streaming section below](/docs/api-reference/responses-streaming)<br/>
        /// for more information.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseVariant3(
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>> input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Includable>? include,
            bool? parallelToolCalls,
            bool? store,
            bool? stream)
        {
            this.Input = input;
            this.Include = include;
            this.ParallelToolCalls = parallelToolCalls;
            this.Store = store;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
        public CreateResponseVariant3()
        {
        }
    }
}