
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeResponseCreateParamsTool
    {
        /// <summary>
        /// The type of the tool, i.e. `function`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreateParamsToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseCreateParamsToolType? Type { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the function, including guidance on when and how <br/>
        /// to call it, and guidance about what to tell the user when calling <br/>
        /// (if anything).
        /// </summary>
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
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParamsTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool, i.e. `function`.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="description">
        /// The description of the function, including guidance on when and how <br/>
        /// to call it, and guidance about what to tell the user when calling <br/>
        /// (if anything).
        /// </param>
        /// <param name="parameters">
        /// Parameters of the function in JSON Schema.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseCreateParamsTool(
            global::tryAGI.OpenAI.RealtimeResponseCreateParamsToolType? type,
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
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParamsTool" /> class.
        /// </summary>
        public RealtimeResponseCreateParamsTool()
        {
        }
    }
}