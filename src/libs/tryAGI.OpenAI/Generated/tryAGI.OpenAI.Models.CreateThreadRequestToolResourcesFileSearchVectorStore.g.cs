
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadRequestToolResourcesFileSearchVectorStore
    {
        /// <summary>
        /// A list of [file](/docs/api-reference/files) IDs to add to the vector store. For vector stores created before Nov 2025, there can be a maximum of 10,000 files in a vector store. For vector stores created starting in Nov 2025, the limit is 100,000,000 files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>))]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>? ChunkingStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStore" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// A list of [file](/docs/api-reference/files) IDs to add to the vector store. For vector stores created before Nov 2025, there can be a maximum of 10,000 files in a vector store. For vector stores created starting in Nov 2025, the limit is 100,000,000 files.
        /// </param>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateThreadRequestToolResourcesFileSearchVectorStore(
            global::System.Collections.Generic.IList<string>? fileIds,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyAutoChunkingStrategy, global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy>? chunkingStrategy,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.FileIds = fileIds;
            this.ChunkingStrategy = chunkingStrategy;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStore" /> class.
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStore()
        {
        }
    }
}