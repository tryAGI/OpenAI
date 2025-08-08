
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
        /// Specify additional output data to include in the model response. Currently<br/>
        /// supported values are:<br/>
        /// - `code_interpreter_call.outputs`: Includes the outputs of python code execution<br/>
        ///   in code interpreter tool call items.<br/>
        /// - `computer_call_output.output.image_url`: Include image urls from the computer call output.<br/>
        /// - `file_search_call.results`: Include the search results of<br/>
        ///   the file search tool call.<br/>
        /// - `message.input_image.image_url`: Include image urls from the input message.<br/>
        /// - `message.output_text.logprobs`: Include logprobs with assistant messages.<br/>
        /// - `reasoning.encrypted_content`: Includes an encrypted version of reasoning<br/>
        ///   tokens in reasoning item outputs. This enables reasoning items to be used in<br/>
        ///   multi-turn conversations when using the Responses API statelessly (like<br/>
        ///   when the `store` parameter is set to `false`, or when an organization is<br/>
        ///   enrolled in the zero data retention program).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Includable>? Include { get; set; }

        /// <summary>
        /// Text, image, or file inputs to the model, used to generate a response.<br/>
        /// Learn more:<br/>
        /// - [Text inputs and outputs](https://platform.openai.com/docs/guides/text)<br/>
        /// - [Image inputs](https://platform.openai.com/docs/guides/images)<br/>
        /// - [File inputs](https://platform.openai.com/docs/guides/pdf-files)<br/>
        /// - [Conversation state](https://platform.openai.com/docs/guides/conversation-state)<br/>
        /// - [Function calling](https://platform.openai.com/docs/guides/function-calling)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? Input { get; set; }

        /// <summary>
        /// A system (or developer) message inserted into the model's context.<br/>
        /// When using along with `previous_response_id`, the instructions from a previous<br/>
        /// response will not be carried over to the next response. This makes it simple<br/>
        /// to swap out system (or developer) messages in new responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

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
        /// See the [Streaming section below](https://platform.openai.com/docs/api-reference/responses-streaming)<br/>
        /// for more information.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Options for streaming responses. Only set this when you set `stream: true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::tryAGI.OpenAI.ResponseStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
        /// <param name="include">
        /// Specify additional output data to include in the model response. Currently<br/>
        /// supported values are:<br/>
        /// - `code_interpreter_call.outputs`: Includes the outputs of python code execution<br/>
        ///   in code interpreter tool call items.<br/>
        /// - `computer_call_output.output.image_url`: Include image urls from the computer call output.<br/>
        /// - `file_search_call.results`: Include the search results of<br/>
        ///   the file search tool call.<br/>
        /// - `message.input_image.image_url`: Include image urls from the input message.<br/>
        /// - `message.output_text.logprobs`: Include logprobs with assistant messages.<br/>
        /// - `reasoning.encrypted_content`: Includes an encrypted version of reasoning<br/>
        ///   tokens in reasoning item outputs. This enables reasoning items to be used in<br/>
        ///   multi-turn conversations when using the Responses API statelessly (like<br/>
        ///   when the `store` parameter is set to `false`, or when an organization is<br/>
        ///   enrolled in the zero data retention program).
        /// </param>
        /// <param name="input">
        /// Text, image, or file inputs to the model, used to generate a response.<br/>
        /// Learn more:<br/>
        /// - [Text inputs and outputs](https://platform.openai.com/docs/guides/text)<br/>
        /// - [Image inputs](https://platform.openai.com/docs/guides/images)<br/>
        /// - [File inputs](https://platform.openai.com/docs/guides/pdf-files)<br/>
        /// - [Conversation state](https://platform.openai.com/docs/guides/conversation-state)<br/>
        /// - [Function calling](https://platform.openai.com/docs/guides/function-calling)
        /// </param>
        /// <param name="instructions">
        /// A system (or developer) message inserted into the model's context.<br/>
        /// When using along with `previous_response_id`, the instructions from a previous<br/>
        /// response will not be carried over to the next response. This makes it simple<br/>
        /// to swap out system (or developer) messages in new responses.
        /// </param>
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
        /// See the [Streaming section below](https://platform.openai.com/docs/api-reference/responses-streaming)<br/>
        /// for more information.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Options for streaming responses. Only set this when you set `stream: true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseVariant3(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Includable>? include,
            global::tryAGI.OpenAI.AnyOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? input,
            string? instructions,
            bool? parallelToolCalls,
            bool? store,
            bool? stream,
            global::tryAGI.OpenAI.ResponseStreamOptions? streamOptions)
        {
            this.Include = include;
            this.Input = input;
            this.Instructions = instructions;
            this.ParallelToolCalls = parallelToolCalls;
            this.Store = store;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
        public CreateResponseVariant3()
        {
        }
    }
}