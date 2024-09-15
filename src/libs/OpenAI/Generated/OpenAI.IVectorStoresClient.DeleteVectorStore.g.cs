#nullable enable

namespace OpenAI
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Delete a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.DeleteVectorStoreResponse> DeleteVectorStoreAsync(
            string vectorStoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}