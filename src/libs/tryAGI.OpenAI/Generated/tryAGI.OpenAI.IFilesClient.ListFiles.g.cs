#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns a list of files.
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="limit">
        /// Default Value: 10000
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListFilesResponse> ListFilesAsync(
            string? purpose = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListFilesOrder? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of files.
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="limit">
        /// Default Value: 10000
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ListFilesResponse>> ListFilesAsResponseAsync(
            string? purpose = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListFilesOrder? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListFilesAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.OpenAIFile&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="limit">
        /// Default Value: 10000
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.OpenAIFile> ListFilesAutoPagingAsync(
              string? purpose = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListFilesOrder? order = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}