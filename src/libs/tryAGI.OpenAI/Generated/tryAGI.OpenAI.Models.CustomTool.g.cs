
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A custom tool that processes input using a specified format. Learn more about<br/>
    /// [custom tools](https://platform.openai.com/docs/guides/function-calling#custom-tools).
    /// </summary>
    public sealed partial class CustomTool
    {
        /// <summary>
        /// Optional description of the custom tool, used to provide more context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The input format for the custom tool. Default is unconstrained text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FormatJsonConverter))]
        public global::tryAGI.OpenAI.Format? Format { get; set; }

        /// <summary>
        /// The name of the custom tool, used to identify it in tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of the custom tool. Always `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CustomToolTypeJsonConverter))]
        public global::tryAGI.OpenAI.CustomToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTool" /> class.
        /// </summary>
        /// <param name="description">
        /// Optional description of the custom tool, used to provide more context.
        /// </param>
        /// <param name="format">
        /// The input format for the custom tool. Default is unconstrained text.
        /// </param>
        /// <param name="name">
        /// The name of the custom tool, used to identify it in tool calls.
        /// </param>
        /// <param name="type">
        /// The type of the custom tool. Always `custom`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTool(
            string name,
            string? description,
            global::tryAGI.OpenAI.Format? format,
            global::tryAGI.OpenAI.CustomToolType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Format = format;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTool" /> class.
        /// </summary>
        public CustomTool()
        {
        }
    }
}