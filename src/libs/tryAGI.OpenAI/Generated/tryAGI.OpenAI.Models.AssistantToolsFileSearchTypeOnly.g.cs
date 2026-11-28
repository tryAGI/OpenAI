
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantToolsFileSearchTypeOnly
    {
        /// <summary>
        /// The type of tool being defined: `file_search`
        /// </summary>
        /// <default>"file_search"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file_search";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearchTypeOnly" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool being defined: `file_search`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantToolsFileSearchTypeOnly(
            string type = "file_search")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearchTypeOnly" /> class.
        /// </summary>
        public AssistantToolsFileSearchTypeOnly()
        {
        }

    }
}