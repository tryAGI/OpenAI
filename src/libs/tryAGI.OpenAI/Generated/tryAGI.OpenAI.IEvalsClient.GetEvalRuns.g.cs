#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get a list of runs for an evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EvalRunList> GetEvalRunsAsync(
            string evalId,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.GetEvalRunsOrder? order = default,
            global::tryAGI.OpenAI.GetEvalRunsStatus? status = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a list of runs for an evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.EvalRunList>> GetEvalRunsAsResponseAsync(
            string evalId,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.GetEvalRunsOrder? order = default,
            global::tryAGI.OpenAI.GetEvalRunsStatus? status = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps GetEvalRunsAsync as an IAsyncEnumerable<global::tryAGI.OpenAI.EvalRun> that auto-pages over the response.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="status"></param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.EvalRun> GetEvalRunsAutoPagingAsync(
            string evalId,             int? limit = default,
            global::tryAGI.OpenAI.GetEvalRunsOrder? order = default,
            global::tryAGI.OpenAI.GetEvalRunsStatus? status = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}