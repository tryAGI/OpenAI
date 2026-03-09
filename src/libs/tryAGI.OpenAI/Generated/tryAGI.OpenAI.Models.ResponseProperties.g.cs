
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseProperties
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// Model ID used to generate the response, like `gpt-4o` or `o3`. OpenAI<br/>
        /// offers a wide range of models with different capabilities, performance<br/>
        /// characteristics, and price points. Refer to the [model guide](/docs/models)<br/>
        /// to browse and compare available models.<br/>
        /// Example: gpt-5.1
        /// </summary>
        /// <example>gpt-5.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesJsonConverter))]
        public global::tryAGI.OpenAI.ModelIdsResponses? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::tryAGI.OpenAI.Reasoning? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Structured Outputs](/docs/guides/structured-outputs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::tryAGI.OpenAI.ResponseTextParam? Text { get; set; }

        /// <summary>
        /// An array of tools the model may call while generating a response. You<br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// We support the following categories of tools:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](/docs/guides/tools-web-search)<br/>
        ///   or [file search](/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](/docs/guides/tools).<br/>
        /// - **MCP Tools**: Integrations with third-party systems via custom MCP servers<br/>
        ///   or predefined connectors such as Google Drive and SharePoint. Learn more about<br/>
        ///   [MCP Tools](/docs/guides/tools-connectors-mcp).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code with strongly typed arguments<br/>
        ///   and outputs. Learn more about<br/>
        ///   [function calling](/docs/guides/function-calling). You can also use<br/>
        ///   custom tools to call your own code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? Tools { get; set; }

        /// <summary>
        /// How the model should select which tool (or tools) to use when generating<br/>
        /// a response. See the `tools` parameter to see how to specify which tools<br/>
        /// the model can call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceParamJsonConverter))]
        public global::tryAGI.OpenAI.ToolChoiceParam? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::tryAGI.OpenAI.PromptVariant1? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        public global::tryAGI.OpenAI.ResponsePropertiesTruncation2? Truncation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseProperties" /> class.
        /// </summary>
        /// <param name="previousResponseId"></param>
        /// <param name="model">
        /// Model ID used to generate the response, like `gpt-4o` or `o3`. OpenAI<br/>
        /// offers a wide range of models with different capabilities, performance<br/>
        /// characteristics, and price points. Refer to the [model guide](/docs/models)<br/>
        /// to browse and compare available models.<br/>
        /// Example: gpt-5.1
        /// </param>
        /// <param name="reasoning"></param>
        /// <param name="background"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="maxToolCalls"></param>
        /// <param name="text">
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Structured Outputs](/docs/guides/structured-outputs)
        /// </param>
        /// <param name="tools">
        /// An array of tools the model may call while generating a response. You<br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// We support the following categories of tools:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](/docs/guides/tools-web-search)<br/>
        ///   or [file search](/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](/docs/guides/tools).<br/>
        /// - **MCP Tools**: Integrations with third-party systems via custom MCP servers<br/>
        ///   or predefined connectors such as Google Drive and SharePoint. Learn more about<br/>
        ///   [MCP Tools](/docs/guides/tools-connectors-mcp).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code with strongly typed arguments<br/>
        ///   and outputs. Learn more about<br/>
        ///   [function calling](/docs/guides/function-calling). You can also use<br/>
        ///   custom tools to call your own code.
        /// </param>
        /// <param name="toolChoice">
        /// How the model should select which tool (or tools) to use when generating<br/>
        /// a response. See the `tools` parameter to see how to specify which tools<br/>
        /// the model can call.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="truncation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseProperties(
            string? previousResponseId,
            global::tryAGI.OpenAI.ModelIdsResponses? model,
            global::tryAGI.OpenAI.Reasoning? reasoning,
            bool? background,
            int? maxOutputTokens,
            int? maxToolCalls,
            global::tryAGI.OpenAI.ResponseTextParam? text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? tools,
            global::tryAGI.OpenAI.ToolChoiceParam? toolChoice,
            global::tryAGI.OpenAI.PromptVariant1? prompt,
            global::tryAGI.OpenAI.ResponsePropertiesTruncation2? truncation)
        {
            this.PreviousResponseId = previousResponseId;
            this.Model = model;
            this.Reasoning = reasoning;
            this.Background = background;
            this.MaxOutputTokens = maxOutputTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Text = text;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Prompt = prompt;
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