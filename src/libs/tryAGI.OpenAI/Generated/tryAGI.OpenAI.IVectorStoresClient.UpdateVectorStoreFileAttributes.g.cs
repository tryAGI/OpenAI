#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Update attributes on a vector store file.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="fileId">
        /// Example: file-abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VectorStoreFileObject> UpdateVectorStoreFileAttributesAsync(
            string vectorStoreId,
            string fileId,

            global::tryAGI.OpenAI.UpdateVectorStoreFileAttributesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update attributes on a vector store file.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="fileId">
        /// Example: file-abc123
        /// </param>
        /// <param name="attributes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VectorStoreFileObject> UpdateVectorStoreFileAttributesAsync(
            string vectorStoreId,
            string fileId,
            object? attributes,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}