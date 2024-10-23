
#nullable enable

namespace OpenAI
{
    public partial class VectorStoresClient
    {
        partial void PrepareListVectorStoreFilesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string vectorStoreId,
            ref int? limit,
            ref global::OpenAI.ListVectorStoreFilesOrder? order,
            ref string? after,
            ref string? before,
            ref global::OpenAI.ListVectorStoreFilesFilter? filter);
        partial void PrepareListVectorStoreFilesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string vectorStoreId,
            int? limit,
            global::OpenAI.ListVectorStoreFilesOrder? order,
            string? after,
            string? before,
            global::OpenAI.ListVectorStoreFilesFilter? filter);
        partial void ProcessListVectorStoreFilesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListVectorStoreFilesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Returns a list of vector store files.
        /// </summary>
        /// <param name="vectorStoreId"></param>
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
        public async global::System.Threading.Tasks.Task<global::OpenAI.ListVectorStoreFilesResponse> ListVectorStoreFilesAsync(
            string vectorStoreId,
            int? limit = 20,
            global::OpenAI.ListVectorStoreFilesOrder? order = global::OpenAI.ListVectorStoreFilesOrder.Desc,
            string? after = default,
            string? before = default,
            global::OpenAI.ListVectorStoreFilesFilter? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListVectorStoreFilesArguments(
                httpClient: HttpClient,
                vectorStoreId: ref vectorStoreId,
                limit: ref limit,
                order: ref order,
                after: ref after,
                before: ref before,
                filter: ref filter);

            var __pathBuilder = new PathBuilder(
                path: $"/vector_stores/{vectorStoreId}/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("order", order?.ToValueString()) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("filter", filter?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListVectorStoreFilesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                vectorStoreId: vectorStoreId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                filter: filter);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListVectorStoreFilesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessListVectorStoreFilesResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::OpenAI.ListVectorStoreFilesResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}