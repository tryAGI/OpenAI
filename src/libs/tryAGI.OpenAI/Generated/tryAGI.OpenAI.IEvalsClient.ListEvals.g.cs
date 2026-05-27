#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// List evaluations for a project.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EvalList> ListEvalsAsync(
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListEvalsOrder? order = default,
            global::tryAGI.OpenAI.ListEvalsOrderBy? orderBy = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List evaluations for a project.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.EvalList>> ListEvalsAsResponseAsync(
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListEvalsOrder? order = default,
            global::tryAGI.OpenAI.ListEvalsOrderBy? orderBy = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListEvalsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.Eval&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Default Value: created_at
        /// </param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.Eval> ListEvalsAutoPagingAsync(
              int? limit = default,
            global::tryAGI.OpenAI.ListEvalsOrder? order = default,
            global::tryAGI.OpenAI.ListEvalsOrderBy? orderBy = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}