
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadObjectToolResourcesCodeInterpreter
    {
        /// <summary>
        /// A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadObjectToolResourcesCodeInterpreter" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ThreadObjectToolResourcesCodeInterpreter(
            global::System.Collections.Generic.IList<string>? fileIds)
        {
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadObjectToolResourcesCodeInterpreter" /> class.
        /// </summary>
        public ThreadObjectToolResourcesCodeInterpreter()
        {
        }
    }
}