
#nullable enable

namespace OpenAI
{
    public partial class VectorStoresClient
    {
        partial void PrepareListFilesInVectorStoreBatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string vectorStoreId,
            ref string batchId,
            ref int limit,
            ref global::OpenAI.ListFilesInVectorStoreBatchOrder? order,
            ref string? after,
            ref string? before,
            ref global::OpenAI.ListFilesInVectorStoreBatchFilter? filter);
        partial void PrepareListFilesInVectorStoreBatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string vectorStoreId,
            string batchId,
            int limit,
            global::OpenAI.ListFilesInVectorStoreBatchOrder? order,
            string? after,
            string? before,
            global::OpenAI.ListFilesInVectorStoreBatchFilter? filter);
        partial void ProcessListFilesInVectorStoreBatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFilesInVectorStoreBatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.ListVectorStoreFilesResponse> ListFilesInVectorStoreBatchAsync(
            string vectorStoreId,
            string batchId,
            int limit,
            global::OpenAI.ListFilesInVectorStoreBatchOrder? order,
            string? after,
            string? before,
            global::OpenAI.ListFilesInVectorStoreBatchFilter? filter,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListFilesInVectorStoreBatchArguments(
                httpClient: _httpClient,
                vectorStoreId: ref vectorStoreId,
                batchId: ref batchId,
                limit: ref limit,
                order: ref order,
                after: ref after,
                before: ref before,
                filter: ref filter);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/vector_stores/{vectorStoreId}/file_batches/{batchId}/files?limit={limit}&order={order}&after={after}&before={before}&filter={filter}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListFilesInVectorStoreBatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                vectorStoreId: vectorStoreId,
                batchId: batchId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                filter: filter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListFilesInVectorStoreBatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListFilesInVectorStoreBatchResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::OpenAI.SourceGenerationContext.Default.ListVectorStoreFilesResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}