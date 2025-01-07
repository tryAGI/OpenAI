
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
    /// </summary>
    public sealed partial class ModifyAssistantRequestToolResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter")]
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter? CodeInterpreter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch? FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequestToolResources" /> class.
        /// </summary>
        /// <param name="codeInterpreter"></param>
        /// <param name="fileSearch"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModifyAssistantRequestToolResources(
            global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesCodeInterpreter? codeInterpreter,
            global::tryAGI.OpenAI.ModifyAssistantRequestToolResourcesFileSearch? fileSearch)
        {
            this.CodeInterpreter = codeInterpreter;
            this.FileSearch = fileSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequestToolResources" /> class.
        /// </summary>
        public ModifyAssistantRequestToolResources()
        {
        }
    }
}