#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get a list of output items for an evaluation run.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="status"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EvalRunOutputItemList> GetEvalRunOutputItemsAsync(
            string evalId,
            string runId,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus? status = default,
            global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a list of output items for an evaluation run.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="status"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.EvalRunOutputItemList>> GetEvalRunOutputItemsAsResponseAsync(
            string evalId,
            string runId,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus? status = default,
            global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps GetEvalRunOutputItemsAsync as an IAsyncEnumerable<global::tryAGI.OpenAI.EvalRunOutputItem> that auto-pages over the response.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="status"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.EvalRunOutputItem> GetEvalRunOutputItemsAutoPagingAsync(
            string evalId,
            string runId,             int? limit = default,
            global::tryAGI.OpenAI.GetEvalRunOutputItemsStatus? status = default,
            global::tryAGI.OpenAI.GetEvalRunOutputItemsOrder? order = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}