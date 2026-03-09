#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Create a vector store file batch.<br/>
        /// The maximum number of files in a single batch request is 2000.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VectorStoreFileBatchObject> CreateVectorStoreFileBatchAsync(
            string vectorStoreId,

            global::tryAGI.OpenAI.CreateVectorStoreFileBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a vector store file batch.<br/>
        /// The maximum number of files in a single batch request is 2000.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="fileIds">
        /// A list of [File](/docs/api-reference/files) IDs that the vector store should use. Useful for tools like `file_search` that can access files.  If `attributes` or `chunking_strategy` are provided, they will be  applied to all files in the batch. The maximum batch size is 2000 files. Mutually exclusive with `files`.
        /// </param>
        /// <param name="files">
        /// A list of objects that each include a `file_id` plus optional `attributes` or `chunking_strategy`. Use this when you need to override metadata for specific files. The global `attributes` or `chunking_strategy` will be ignored and must be specified for each file. The maximum batch size is 2000 files. Mutually exclusive with `file_ids`.
        /// </param>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
        /// </param>
        /// <param name="attributes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VectorStoreFileBatchObject> CreateVectorStoreFileBatchAsync(
            string vectorStoreId,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateVectorStoreFileRequest>? files = default,
            global::tryAGI.OpenAI.ChunkingStrategyRequestParam? chunkingStrategy = default,
            object? attributes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}