
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A set of resources that are made available to the assistant's tools in this thread. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
    /// </summary>
    public sealed partial class ThreadObjectToolResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter")]
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter? CodeInterpreter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch? FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadObjectToolResources" /> class.
        /// </summary>
        /// <param name="codeInterpreter"></param>
        /// <param name="fileSearch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadObjectToolResources(
            global::tryAGI.OpenAI.ThreadObjectToolResourcesCodeInterpreter? codeInterpreter,
            global::tryAGI.OpenAI.ThreadObjectToolResourcesFileSearch? fileSearch)
        {
            this.CodeInterpreter = codeInterpreter;
            this.FileSearch = fileSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadObjectToolResources" /> class.
        /// </summary>
        public ThreadObjectToolResources()
        {
        }
    }
}