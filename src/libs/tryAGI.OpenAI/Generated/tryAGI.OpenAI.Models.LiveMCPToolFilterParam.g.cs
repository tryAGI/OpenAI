
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveMCPToolFilterParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPToolFilterParam" /> class.
        /// </summary>
        /// <param name="toolNames"></param>
        /// <param name="readOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveMCPToolFilterParam(
            global::System.Collections.Generic.IList<string>? toolNames,
            bool? readOnly)
        {
            this.ToolNames = toolNames;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveMCPToolFilterParam" /> class.
        /// </summary>
        public LiveMCPToolFilterParam()
        {
        }

    }
}