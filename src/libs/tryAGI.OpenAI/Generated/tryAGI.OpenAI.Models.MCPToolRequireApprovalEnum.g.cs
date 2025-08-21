
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specify which of the MCP server's tools require approval. Can be<br/>
    /// `always`, `never`, or a filter object associated with tools<br/>
    /// that require approval.
    /// </summary>
    public sealed partial class MCPToolRequireApprovalEnum
    {
        /// <summary>
        /// A filter object to specify which tools are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always")]
        public global::tryAGI.OpenAI.MCPToolFilter? Always { get; set; }

        /// <summary>
        /// A filter object to specify which tools are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("never")]
        public global::tryAGI.OpenAI.MCPToolFilter? Never { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolRequireApprovalEnum" /> class.
        /// </summary>
        /// <param name="always">
        /// A filter object to specify which tools are allowed.
        /// </param>
        /// <param name="never">
        /// A filter object to specify which tools are allowed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolRequireApprovalEnum(
            global::tryAGI.OpenAI.MCPToolFilter? always,
            global::tryAGI.OpenAI.MCPToolFilter? never)
        {
            this.Always = always;
            this.Never = never;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolRequireApprovalEnum" /> class.
        /// </summary>
        public MCPToolRequireApprovalEnum()
        {
        }
    }
}