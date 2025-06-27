
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalCompletionsRunDataSourceSamplingParams
    {
        /// <summary>
        /// The maximum number of tokens in the generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>? ResponseFormat { get; set; }

        /// <summary>
        /// A seed value to initialize the randomness, during sampling.<br/>
        /// Default Value: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A higher temperature increases randomness in the outputs.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceSamplingParams" /> class.
        /// </summary>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens in the generated output.
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables<br/>
        /// Structured Outputs which ensures the model will match your supplied JSON<br/>
        /// schema. Learn more in the [Structured Outputs<br/>
        /// guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
        /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
        /// is preferred for models that support it.
        /// </param>
        /// <param name="seed">
        /// A seed value to initialize the randomness, during sampling.<br/>
        /// Default Value: 42
        /// </param>
        /// <param name="temperature">
        /// A higher temperature increases randomness in the outputs.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.
        /// </param>
        /// <param name="topP">
        /// An alternative to temperature for nucleus sampling; 1.0 includes all tokens.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalCompletionsRunDataSourceSamplingParams(
            int? maxCompletionTokens,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.ResponseFormatText, global::tryAGI.OpenAI.ResponseFormatJsonSchema, global::tryAGI.OpenAI.ResponseFormatJsonObject>? responseFormat,
            int? seed,
            double? temperature,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ChatCompletionTool>? tools,
            double? topP)
        {
            this.MaxCompletionTokens = maxCompletionTokens;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.Temperature = temperature;
            this.Tools = tools;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSourceSamplingParams" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSourceSamplingParams()
        {
        }
    }
}