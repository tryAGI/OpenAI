
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaFunctionToolParam
    {
        /// <summary>
        /// 
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
        public global::tryAGI.OpenAI.BetaEmptyModelParam? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Default Value: function
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaFunctionToolParamType.Function</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaFunctionToolParamType Type { get; set; } = global::tryAGI.OpenAI.BetaFunctionToolParamType.Function;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Whether this function should be deferred and discovered via tool search.
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
        /// Initializes a new instance of the <see cref="BetaFunctionToolParam" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="strict"></param>
        /// <param name="outputSchema"></param>
        /// <param name="deferLoading">
        /// Whether this function should be deferred and discovered via tool search.
        /// </param>
        /// <param name="allowedCallers"></param>
        /// <param name="type">
        /// Default Value: function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFunctionToolParam(
            string name,
            string? description,
            global::tryAGI.OpenAI.BetaEmptyModelParam? parameters,
            bool? strict,
            object? outputSchema,
            bool? deferLoading,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>? allowedCallers,
            global::tryAGI.OpenAI.BetaFunctionToolParamType type = global::tryAGI.OpenAI.BetaFunctionToolParamType.Function)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
            this.Strict = strict;
            this.Type = type;
            this.OutputSchema = outputSchema;
            this.DeferLoading = deferLoading;
            this.AllowedCallers = allowedCallers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFunctionToolParam" /> class.
        /// </summary>
        public BetaFunctionToolParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaFunctionToolParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaFunctionToolParam FromName(string name)
        {
            return new BetaFunctionToolParam
            {
                Name = name,
            };
        }

    }
}