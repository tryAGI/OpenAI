
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A filter object to specify which tools are allowed.
    /// </summary>
    public sealed partial class MCPToolFilter
    {
        /// <summary>
        /// Indicates whether or not a tool modifies data or is read-only. If an<br/>
        /// MCP server is [annotated with `readOnlyHint`](https://modelcontextprotocol.io/specification/2025-06-18/schema#toolannotations-readonlyhint),<br/>
        /// it will match this filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// List of allowed tool names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolFilter" /> class.
        /// </summary>
        /// <param name="readOnly">
        /// Indicates whether or not a tool modifies data or is read-only. If an<br/>
        /// MCP server is [annotated with `readOnlyHint`](https://modelcontextprotocol.io/specification/2025-06-18/schema#toolannotations-readonlyhint),<br/>
        /// it will match this filter.
        /// </param>
        /// <param name="toolNames">
        /// List of allowed tool names.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolFilter(
            bool? readOnly,
            global::System.Collections.Generic.IList<string>? toolNames)
        {
            this.ReadOnly = readOnly;
            this.ToolNames = toolNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolFilter" /> class.
        /// </summary>
        public MCPToolFilter()
        {
        }
    }
}