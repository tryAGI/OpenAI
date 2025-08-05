#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Cancel vector store file batch<br/>
        /// Cancel a vector store file batch. This attempts to cancel the processing of files in this batch as soon as possible.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VectorStoreFileBatchObject> CancelVectorStoreFileBatchAsync(
            string vectorStoreId,
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}