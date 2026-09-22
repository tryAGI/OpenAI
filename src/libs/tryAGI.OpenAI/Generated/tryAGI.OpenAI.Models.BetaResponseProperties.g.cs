
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResponseProperties
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// Model ID used to generate the response, like `gpt-6-astra`. OpenAI<br/>
        /// offers a wide range of models with different capabilities, performance<br/>
        /// characteristics, and price points. Refer to the [model guide](https://developers.openai.com/api/docs/models)<br/>
        /// to browse and compare available models.<br/>
        /// Example: gpt-6-astra
        /// </summary>
        /// <example>gpt-6-astra</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaModelIdsResponsesJsonConverter))]
        public global::tryAGI.OpenAI.BetaModelIdsResponses? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](https://developers.openai.com/api/docs/guides/text)<br/>
        /// - [Structured Outputs](https://developers.openai.com/api/docs/guides/structured-outputs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::tryAGI.OpenAI.BetaResponseTextParam? Text { get; set; }

        /// <summary>
        /// An array of tools the model may call while generating a response. You<br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// We support the following categories of tools:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](https://developers.openai.com/api/docs/guides/tools-web-search)<br/>
        ///   or [file search](https://developers.openai.com/api/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](https://developers.openai.com/api/docs/guides/tools).<br/>
        /// - **MCP Tools**: Integrations with third-party systems via custom MCP servers<br/>
        ///   or predefined connectors such as Google Drive and SharePoint. Learn more about<br/>
        ///   [MCP Tools](https://developers.openai.com/api/docs/guides/tools-connectors-mcp).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code with strongly typed arguments<br/>
        ///   and outputs. Learn more about<br/>
        ///   [function calling](https://developers.openai.com/api/docs/guides/function-calling). You can also use<br/>
        ///   custom tools to call your own code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? Tools { get; set; }

        /// <summary>
        /// How the model should select which tool (or tools) to use when generating<br/>
        /// a response. See the `tools` parameter to see how to specify which tools<br/>
        /// the model can call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceParamJsonConverter))]
        public global::tryAGI.OpenAI.BetaToolChoiceParam? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::tryAGI.OpenAI.BetaPromptVariant1? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseProperties" /> class.
        /// </summary>
        /// <param name="previousResponseId"></param>
        /// <param name="model">
        /// Model ID used to generate the response, like `gpt-6-astra`. OpenAI<br/>
        /// offers a wide range of models with different capabilities, performance<br/>
        /// characteristics, and price points. Refer to the [model guide](https://developers.openai.com/api/docs/models)<br/>
        /// to browse and compare available models.<br/>
        /// Example: gpt-6-astra
        /// </param>
        /// <param name="background"></param>
        /// <param name="maxToolCalls"></param>
        /// <param name="text">
        /// Configuration options for a text response from the model. Can be plain<br/>
        /// text or structured JSON data. Learn more:<br/>
        /// - [Text inputs and outputs](https://developers.openai.com/api/docs/guides/text)<br/>
        /// - [Structured Outputs](https://developers.openai.com/api/docs/guides/structured-outputs)
        /// </param>
        /// <param name="tools">
        /// An array of tools the model may call while generating a response. You<br/>
        /// can specify which tool to use by setting the `tool_choice` parameter.<br/>
        /// We support the following categories of tools:<br/>
        /// - **Built-in tools**: Tools that are provided by OpenAI that extend the<br/>
        ///   model's capabilities, like [web search](https://developers.openai.com/api/docs/guides/tools-web-search)<br/>
        ///   or [file search](https://developers.openai.com/api/docs/guides/tools-file-search). Learn more about<br/>
        ///   [built-in tools](https://developers.openai.com/api/docs/guides/tools).<br/>
        /// - **MCP Tools**: Integrations with third-party systems via custom MCP servers<br/>
        ///   or predefined connectors such as Google Drive and SharePoint. Learn more about<br/>
        ///   [MCP Tools](https://developers.openai.com/api/docs/guides/tools-connectors-mcp).<br/>
        /// - **Function calls (custom tools)**: Functions that are defined by you,<br/>
        ///   enabling the model to call your own code with strongly typed arguments<br/>
        ///   and outputs. Learn more about<br/>
        ///   [function calling](https://developers.openai.com/api/docs/guides/function-calling). You can also use<br/>
        ///   custom tools to call your own code.
        /// </param>
        /// <param name="toolChoice">
        /// How the model should select which tool (or tools) to use when generating<br/>
        /// a response. See the `tools` parameter to see how to specify which tools<br/>
        /// the model can call.
        /// </param>
        /// <param name="prompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseProperties(
            string? previousResponseId,
            global::tryAGI.OpenAI.BetaModelIdsResponses? model,
            bool? background,
            int? maxToolCalls,
            global::tryAGI.OpenAI.BetaResponseTextParam? text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? tools,
            global::tryAGI.OpenAI.BetaToolChoiceParam? toolChoice,
            global::tryAGI.OpenAI.BetaPromptVariant1? prompt)
        {
            this.PreviousResponseId = previousResponseId;
            this.Model = model;
            this.Background = background;
            this.MaxToolCalls = maxToolCalls;
            this.Text = text;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseProperties" /> class.
        /// </summary>
        public BetaResponseProperties()
        {
        }

    }
}