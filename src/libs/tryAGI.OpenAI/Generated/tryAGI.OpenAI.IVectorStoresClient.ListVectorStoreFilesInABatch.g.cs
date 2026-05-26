#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Returns a list of vector store files in a batch.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="batchId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListVectorStoreFilesResponse> ListVectorStoreFilesInABatchAsync(
            string vectorStoreId,
            string batchId,
            int? limit = default,
            global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder? order = default,
            string? after = default,
            string? before = default,
            global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter? filter = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of vector store files in a batch.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="batchId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="filter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ListVectorStoreFilesResponse>> ListVectorStoreFilesInABatchAsResponseAsync(
            string vectorStoreId,
            string batchId,
            int? limit = default,
            global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder? order = default,
            string? after = default,
            string? before = default,
            global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter? filter = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListVectorStoreFilesInABatchAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.VectorStoreFileObject&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="batchId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="filter"></param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.VectorStoreFileObject> ListVectorStoreFilesInABatchAutoPagingAsync(
            string vectorStoreId,
            string batchId,             int? limit = default,
            global::tryAGI.OpenAI.ListFilesInVectorStoreBatchOrder? order = default,
            string? before = default,
            global::tryAGI.OpenAI.ListFilesInVectorStoreBatchFilter? filter = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}