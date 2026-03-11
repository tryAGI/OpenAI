
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime item listing tools available on an MCP server.
    /// </summary>
    public sealed partial class RealtimeMCPListTools
    {
        /// <summary>
        /// The type of the item. Always `mcp_list_tools`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeMCPListToolsTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeMCPListToolsType Type { get; set; }

        /// <summary>
        /// The unique ID of the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The label of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ServerLabel { get; set; } = default!;

        /// <summary>
        /// The tools available on the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool> Tools { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPListTools" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the item. Always `mcp_list_tools`.
        /// </param>
        /// <param name="id">
        /// The unique ID of the list.
        /// </param>
        /// <param name="serverLabel">
        /// The label of the MCP server.
        /// </param>
        /// <param name="tools">
        /// The tools available on the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeMCPListTools(
            string serverLabel,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool> tools,
            global::tryAGI.OpenAI.RealtimeMCPListToolsType type,
            string? id)
        {
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeMCPListTools" /> class.
        /// </summary>
        public RealtimeMCPListTools()
        {
        }
    }
}