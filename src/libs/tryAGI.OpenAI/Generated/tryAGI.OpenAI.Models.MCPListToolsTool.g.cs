
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A tool available on an MCP server.
    /// </summary>
    public sealed partial class MCPListToolsTool
    {
        /// <summary>
        /// Additional annotations about the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public object? Annotations { get; set; }

        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The JSON schema describing the tool's input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// The name of the tool.
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
        /// Initializes a new instance of the <see cref="MCPListToolsTool" /> class.
        /// </summary>
        /// <param name="annotations">
        /// Additional annotations about the tool.
        /// </param>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="inputSchema">
        /// The JSON schema describing the tool's input.
        /// </param>
        /// <param name="name">
        /// The name of the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPListToolsTool(
            object inputSchema,
            string name,
            object? annotations,
            string? description)
        {
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Annotations = annotations;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPListToolsTool" /> class.
        /// </summary>
        public MCPListToolsTool()
        {
        }
    }
}