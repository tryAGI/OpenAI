
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
        /// Whether to run the model response in the background. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/background).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// An upper bound for the number of tokens that can be generated for a response, including visible output tokens and [reasoning tokens](https://platform.openai.com/docs/guides/reasoning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// The maximum number of total calls to built-in tools that can be processed in a response. This maximum number applies across all built-in tool calls, not per individual tool. Any further attempts to call a tool by the model will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Example: gpt-4o
        /// </summary>
        /// <example>gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesJsonConverter))]
        public global::tryAGI.OpenAI.ModelIdsResponses? Model { get; set; }

        /// <summary>
        /// The unique ID of the previous response to the model. Use this to<br/>
        /// create multi-turn conversations. Learn more about <br/>
        /// [conversation state](https://platform.openai.com/docs/guides/conversation-state).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// Reference to a prompt template and its variables. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/text?api-mode=responses#reusable-prompts).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::tryAGI.OpenAI.Prompt2? Prompt { get; set; }

        /// <summary>
        /// **o-series models only**<br/>
        /// Configuration options for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.Reasoning? Reasoning { get; set; }

        /// <summary>
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](https://platform.openai.com/docs/guides/text)<br/>
        /// - [Structured Outputs](https://platform.openai.com/docs/guides/structured-outputs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::tryAGI.OpenAI.ResponsePropertiesText? Text { get; set; }

        /// <summary>
        /// How the model should select which tool (or tools) to use when generating<br/>
        /// a response. See the `tools` parameter to see how to specify which tools<br/>
        /// the model can call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceTypes, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>))]
        public global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceTypes, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? ToolChoice { get; set; }

        /// <summary>
        /// An array of tools the model may call while generating a response. You <br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// The two categories of tools you can provide the model are:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](https://platform.openai.com/docs/guides/tools-web-search)<br/>
        ///   or [file search](https://platform.openai.com/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](https://platform.openai.com/docs/guides/tools).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code. Learn more about<br/>
        ///   [function calling](https://platform.openai.com/docs/guides/function-calling).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? Tools { get; set; }

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
        /// <param name="background">
        /// Whether to run the model response in the background. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/background).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxOutputTokens">
        /// An upper bound for the number of tokens that can be generated for a response, including visible output tokens and [reasoning tokens](https://platform.openai.com/docs/guides/reasoning).
        /// </param>
        /// <param name="maxToolCalls">
        /// The maximum number of total calls to built-in tools that can be processed in a response. This maximum number applies across all built-in tool calls, not per individual tool. Any further attempts to call a tool by the model will be ignored.
        /// </param>
        /// <param name="model">
        /// Example: gpt-4o
        /// </param>
        /// <param name="previousResponseId">
        /// The unique ID of the previous response to the model. Use this to<br/>
        /// create multi-turn conversations. Learn more about <br/>
        /// [conversation state](https://platform.openai.com/docs/guides/conversation-state).
        /// </param>
        /// <param name="prompt">
        /// Reference to a prompt template and its variables. <br/>
        /// [Learn more](https://platform.openai.com/docs/guides/text?api-mode=responses#reusable-prompts).
        /// </param>
        /// <param name="reasoning">
        /// **o-series models only**<br/>
        /// Configuration options for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).
        /// </param>
        /// <param name="text">
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](https://platform.openai.com/docs/guides/text)<br/>
        /// - [Structured Outputs](https://platform.openai.com/docs/guides/structured-outputs)
        /// </param>
        /// <param name="toolChoice">
        /// How the model should select which tool (or tools) to use when generating<br/>
        /// a response. See the `tools` parameter to see how to specify which tools<br/>
        /// the model can call.
        /// </param>
        /// <param name="tools">
        /// An array of tools the model may call while generating a response. You <br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// The two categories of tools you can provide the model are:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](https://platform.openai.com/docs/guides/tools-web-search)<br/>
        ///   or [file search](https://platform.openai.com/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](https://platform.openai.com/docs/guides/tools).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code. Learn more about<br/>
        ///   [function calling](https://platform.openai.com/docs/guides/function-calling).
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
            bool? background,
            int? maxOutputTokens,
            int? maxToolCalls,
            global::tryAGI.OpenAI.ModelIdsResponses? model,
            string? previousResponseId,
            global::tryAGI.OpenAI.Prompt2? prompt,
            global::tryAGI.OpenAI.Reasoning? reasoning,
            global::tryAGI.OpenAI.ResponsePropertiesText? text,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceTypes, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>? toolChoice,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? tools,
            global::tryAGI.OpenAI.ResponsePropertiesTruncation? truncation)
        {
            this.Background = background;
            this.MaxOutputTokens = maxOutputTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Model = model;
            this.PreviousResponseId = previousResponseId;
            this.Prompt = prompt;
            this.Reasoning = reasoning;
            this.Text = text;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
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