#nullable enable

namespace OpenAI
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Modifies a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.VectorStoreObject> ModifyVectorStoreAsync(
            string vectorStoreId,
            global::OpenAI.UpdateVectorStoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="name">
        /// The name of the vector store.
        /// </param>
        /// <param name="expiresAfter">
        /// The expiration policy for a vector store.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.VectorStoreObject> ModifyVectorStoreAsync(
            string vectorStoreId,
            string? name = default,
            global::OpenAI.VectorStoreExpirationAfter? expiresAfter = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}