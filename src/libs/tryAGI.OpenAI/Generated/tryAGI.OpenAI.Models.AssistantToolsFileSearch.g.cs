
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantToolsFileSearch
    {
        /// <summary>
        /// The type of tool being defined: `file_search`
        /// </summary>
        /// <default>"file_search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file_search";

        /// <summary>
        /// Overrides for the file search tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public global::tryAGI.OpenAI.AssistantToolsFileSearchFileSearch? FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearch" /> class.
        /// </summary>
        /// <param name="fileSearch">
        /// Overrides for the file search tool.
        /// </param>
        /// <param name="type">
        /// The type of tool being defined: `file_search`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantToolsFileSearch(
            global::tryAGI.OpenAI.AssistantToolsFileSearchFileSearch? fileSearch,
            string type = "file_search")
        {
            this.Type = type;
            this.FileSearch = fileSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearch" /> class.
        /// </summary>
        public AssistantToolsFileSearch()
        {
        }

    }
}