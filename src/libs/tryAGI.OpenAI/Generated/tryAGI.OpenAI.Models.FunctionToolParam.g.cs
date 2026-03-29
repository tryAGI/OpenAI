
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionToolParam
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
        public global::tryAGI.OpenAI.EmptyModelParam? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Default Value: function
        /// </summary>
        /// <default>global::tryAGI.OpenAI.FunctionToolParamType.Function</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FunctionToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.FunctionToolParamType Type { get; set; } = global::tryAGI.OpenAI.FunctionToolParamType.Function;

        /// <summary>
        /// Whether this function should be deferred and discovered via tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionToolParam" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="strict"></param>
        /// <param name="deferLoading">
        /// Whether this function should be deferred and discovered via tool search.
        /// </param>
        /// <param name="type">
        /// Default Value: function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionToolParam(
            string name,
            string? description,
            global::tryAGI.OpenAI.EmptyModelParam? parameters,
            bool? strict,
            bool? deferLoading,
            global::tryAGI.OpenAI.FunctionToolParamType type = global::tryAGI.OpenAI.FunctionToolParamType.Function)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
            this.Strict = strict;
            this.Type = type;
            this.DeferLoading = deferLoading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionToolParam" /> class.
        /// </summary>
        public FunctionToolParam()
        {
        }
    }
}