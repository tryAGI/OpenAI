
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseProperties
    {
        /// <summary>
        /// The unique ID of the previous response to the model. Use this to<br/>
        /// create multi-turn conversations. Learn more about <br/>
        /// [conversation state](/docs/guides/conversation-state).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// **o-series models only**<br/>
        /// Configuration options for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.Reasoning? Reasoning { get; set; }

        /// <summary>
        /// An upper bound for the number of tokens that can be generated for a response, including visible output tokens and [reasoning tokens](/docs/guides/reasoning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Inserts a system (or developer) message as the first item in the model's context.<br/>
        /// When using along with `previous_response_id`, the instructions from a previous<br/>
        /// response will be not be carried over to the next response. This makes it simple<br/>
        /// to swap out system (or developer) messages in new responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Structured Outputs](/docs/guides/structured-outputs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::tryAGI.OpenAI.ResponsePropertiesText? Text { get; set; }

        /// <summary>
        /// An array of tools the model may call while generating a response. You <br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// The two categories of tools you can provide the model are:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](/docs/guides/tools-web-search)<br/>
        ///   or [file search](/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](/docs/guides/tools).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code. Learn more about<br/>
        ///   [function calling](/docs/guides/function-calling).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? Tools { get; set; }

        /// <summary>
        /// How the model should select which tool (or tools) to use when generating<br/>
        /// a response. See the `tools` parameter to see how to specify which tools<br/>
        /// the model can call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceTypes, global::tryAGI.OpenAI.ToolChoiceFunction>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceTypes, global::tryAGI.OpenAI.ToolChoiceFunction>? ToolChoice { get; set; }

        /// <summary>
        /// The truncation strategy to use for the model response.<br/>
        /// - `auto`: If the context of this response and previous ones exceeds<br/>
        ///   the model's context window size, the model will truncate the <br/>
        ///   response to fit the context window by dropping input items in the<br/>
        ///   middle of the conversation. <br/>
        /// - `disabled` (default): If a model response will exceed the context window <br/>
        ///   size for a model, the request will fail with a 400 error.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponsePropertiesTruncationJsonConverter))]
        public global::tryAGI.OpenAI.ResponsePropertiesTruncation? Truncation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseProperties" /> class.
        /// </summary>
        /// <param name="previousResponseId">
        /// The unique ID of the previous response to the model. Use this to<br/>
        /// create multi-turn conversations. Learn more about <br/>
        /// [conversation state](/docs/guides/conversation-state).
        /// </param>
        /// <param name="reasoning">
        /// **o-series models only**<br/>
        /// Configuration options for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).
        /// </param>
        /// <param name="maxOutputTokens">
        /// An upper bound for the number of tokens that can be generated for a response, including visible output tokens and [reasoning tokens](/docs/guides/reasoning).
        /// </param>
        /// <param name="instructions">
        /// Inserts a system (or developer) message as the first item in the model's context.<br/>
        /// When using along with `previous_response_id`, the instructions from a previous<br/>
        /// response will be not be carried over to the next response. This makes it simple<br/>
        /// to swap out system (or developer) messages in new responses.
        /// </param>
        /// <param name="text">
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Structured Outputs](/docs/guides/structured-outputs)
        /// </param>
        /// <param name="tools">
        /// An array of tools the model may call while generating a response. You <br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// The two categories of tools you can provide the model are:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](/docs/guides/tools-web-search)<br/>
        ///   or [file search](/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](/docs/guides/tools).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code. Learn more about<br/>
        ///   [function calling](/docs/guides/function-calling).
        /// </param>
        /// <param name="toolChoice">
        /// How the model should select which tool (or tools) to use when generating<br/>
        /// a response. See the `tools` parameter to see how to specify which tools<br/>
        /// the model can call.
        /// </param>
        /// <param name="truncation">
        /// The truncation strategy to use for the model response.<br/>
        /// - `auto`: If the context of this response and previous ones exceeds<br/>
        ///   the model's context window size, the model will truncate the <br/>
        ///   response to fit the context window by dropping input items in the<br/>
        ///   middle of the conversation. <br/>
        /// - `disabled` (default): If a model response will exceed the context window <br/>
        ///   size for a model, the request will fail with a 400 error.<br/>
        /// Default Value: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseProperties(
            string? previousResponseId,
            global::tryAGI.OpenAI.Reasoning? reasoning,
            int? maxOutputTokens,
            string? instructions,
            global::tryAGI.OpenAI.ResponsePropertiesText? text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? tools,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceTypes, global::tryAGI.OpenAI.ToolChoiceFunction>? toolChoice,
            global::tryAGI.OpenAI.ResponsePropertiesTruncation? truncation)
        {
            this.PreviousResponseId = previousResponseId;
            this.Reasoning = reasoning;
            this.MaxOutputTokens = maxOutputTokens;
            this.Instructions = instructions;
            this.Text = text;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Truncation = truncation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseProperties" /> class.
        /// </summary>
        public ResponseProperties()
        {
        }
    }
}