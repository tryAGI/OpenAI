
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeSessionTool
    {
        /// <summary>
        /// The type of the tool, e.g., "function".<br/>
        /// Example: function
        /// </summary>
        /// <example>function</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the function.<br/>
        /// Example: get_weather
        /// </summary>
        /// <example>get_weather</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the function.<br/>
        /// Example: Get the current weather for a location.
        /// </summary>
        /// <example>Get the current weather for a location.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Parameters of the function in JSON Schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool, e.g., "function".<br/>
        /// Example: function
        /// </param>
        /// <param name="name">
        /// The name of the function.<br/>
        /// Example: get_weather
        /// </param>
        /// <param name="description">
        /// The description of the function.<br/>
        /// Example: Get the current weather for a location.
        /// </param>
        /// <param name="parameters">
        /// Parameters of the function in JSON Schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionTool(
            string? type,
            string? name,
            string? description,
            object? parameters)
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionTool" /> class.
        /// </summary>
        public RealtimeSessionTool()
        {
        }
    }
}