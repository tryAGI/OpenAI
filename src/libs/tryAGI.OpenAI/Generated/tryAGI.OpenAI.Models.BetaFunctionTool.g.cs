
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Defines a function in your own code the model can choose to call. Learn more about [function calling](https://platform.openai.com/docs/guides/function-calling).
    /// </summary>
    public sealed partial class BetaFunctionTool
    {
        /// <summary>
        /// The type of the function tool. Always `function`.<br/>
        /// Default Value: function
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaFunctionToolType.Function</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaFunctionToolType Type { get; set; } = global::tryAGI.OpenAI.BetaFunctionToolType.Function;

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Whether this function is deferred and loaded via tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionTool" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="outputSchema"></param>
        /// <param name="strict"></param>
        /// <param name="deferLoading">
        /// Whether this function is deferred and loaded via tool search.
        /// </param>
        /// <param name="allowedCallers"></param>
        /// <param name="type">
        /// The type of the function tool. Always `function`.<br/>
        /// Default Value: function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFunctionTool(
            string name,
            string? description,
            object? parameters,
            object? outputSchema,
            bool? strict,
            bool? deferLoading,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? allowedCallers,
            global::tryAGI.OpenAI.BetaFunctionToolType type = global::tryAGI.OpenAI.BetaFunctionToolType.Function)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
            this.OutputSchema = outputSchema;
            this.Strict = strict;
            this.DeferLoading = deferLoading;
            this.AllowedCallers = allowedCallers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionTool" /> class.
        /// </summary>
        public BetaFunctionTool()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaFunctionTool"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaFunctionTool FromName(string name)
        {
            return new BetaFunctionTool
            {
                Name = name,
            };
        }

    }
}