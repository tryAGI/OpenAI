
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A custom tool that processes input using a specified format. Learn more about   [custom tools](/docs/guides/function-calling#custom-tools)
    /// </summary>
    public sealed partial class CustomToolParam
    {
        /// <summary>
        /// The type of the custom tool. Always `custom`.<br/>
        /// Default Value: custom
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CustomToolParamType.Custom</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.CustomToolParamType Type { get; set; } = global::tryAGI.OpenAI.CustomToolParamType.Custom;

        /// <summary>
        /// The name of the custom tool, used to identify it in tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description of the custom tool, used to provide more context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The input format for the custom tool. Default is unconstrained text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Format2JsonConverter))]
        public global::tryAGI.OpenAI.Format2? Format { get; set; }

        /// <summary>
        /// Whether this tool should be deferred and discovered via tool search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolParam" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the custom tool, used to identify it in tool calls.
        /// </param>
        /// <param name="description">
        /// Optional description of the custom tool, used to provide more context.
        /// </param>
        /// <param name="format">
        /// The input format for the custom tool. Default is unconstrained text.
        /// </param>
        /// <param name="deferLoading">
        /// Whether this tool should be deferred and discovered via tool search.
        /// </param>
        /// <param name="type">
        /// The type of the custom tool. Always `custom`.<br/>
        /// Default Value: custom
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolParam(
            string name,
            string? description,
            global::tryAGI.OpenAI.Format2? format,
            bool? deferLoading,
            global::tryAGI.OpenAI.CustomToolParamType type = global::tryAGI.OpenAI.CustomToolParamType.Custom)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Format = format;
            this.DeferLoading = deferLoading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolParam" /> class.
        /// </summary>
        public CustomToolParam()
        {
        }
    }
}