
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyAssistantRequestToolResourcesFileSearch
    {
        /// <summary>
        /// Overrides the [vector store](/docs/api-reference/vector-stores/object) attached to this assistant. There can be a maximum of 1 vector store attached to the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_ids")]
        public global::System.Collections.Generic.IList<string>? VectorStoreIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequestToolResourcesFileSearch" /> class.
        /// </summary>
        /// <param name="vectorStoreIds">
        /// Overrides the [vector store](/docs/api-reference/vector-stores/object) attached to this assistant. There can be a maximum of 1 vector store attached to the assistant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModifyAssistantRequestToolResourcesFileSearch(
            global::System.Collections.Generic.IList<string>? vectorStoreIds)
        {
            this.VectorStoreIds = vectorStoreIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequestToolResourcesFileSearch" /> class.
        /// </summary>
        public ModifyAssistantRequestToolResourcesFileSearch()
        {
        }
    }
}