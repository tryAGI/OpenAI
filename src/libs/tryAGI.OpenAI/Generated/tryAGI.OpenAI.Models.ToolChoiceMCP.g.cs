
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use this option to force the model to call a specific tool on a remote MCP server.
    /// </summary>
    public sealed partial class ToolChoiceMCP
    {
        /// <summary>
        /// For MCP tools, the type is always `mcp`.
        /// </summary>
        /// <default>"mcp"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp";

        /// <summary>
        /// The label of the MCP server to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceMCP" /> class.
        /// </summary>
        /// <param name="serverLabel">
        /// The label of the MCP server to use.
        /// </param>
        /// <param name="name"></param>
        /// <param name="type">
        /// For MCP tools, the type is always `mcp`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceMCP(
            string serverLabel,
            string? name,
            string type = "mcp")
        {
            this.Type = type;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceMCP" /> class.
        /// </summary>
        public ToolChoiceMCP()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ToolChoiceMCP"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ToolChoiceMCP FromServerLabel(string serverLabel)
        {
            return new ToolChoiceMCP
            {
                ServerLabel = serverLabel,
            };
        }

    }
}