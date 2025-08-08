
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Properties of the custom tool.
    /// </summary>
    public sealed partial class CustomToolChatCompletionsCustom
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Format2JsonConverter))]
        public global::tryAGI.OpenAI.Format2? Format { get; set; }

        /// <summary>
        /// The name of the custom tool, used to identify it in tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustom" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolChatCompletionsCustom(
            string name,
            string? description,
            global::tryAGI.OpenAI.Format2? format)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolChatCompletionsCustom" /> class.
        /// </summary>
        public CustomToolChatCompletionsCustom()
        {
        }
    }
}