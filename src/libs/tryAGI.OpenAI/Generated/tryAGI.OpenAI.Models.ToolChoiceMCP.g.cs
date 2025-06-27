
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use this option to force the model to call a specific tool on a remote MCP server.
    /// </summary>
    public sealed partial class ToolChoiceMCP
    {
        /// <summary>
        /// The name of the tool to call on the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The label of the MCP server to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        /// For MCP tools, the type is always `mcp`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeJsonConverter))]
        public global::tryAGI.OpenAI.ToolChoiceMCPType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceMCP" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool to call on the server.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server to use.
        /// </param>
        /// <param name="type">
        /// For MCP tools, the type is always `mcp`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceMCP(
            string serverLabel,
            string? name,
            global::tryAGI.OpenAI.ToolChoiceMCPType type)
        {
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceMCP" /> class.
        /// </summary>
        public ToolChoiceMCP()
        {
        }
    }
}