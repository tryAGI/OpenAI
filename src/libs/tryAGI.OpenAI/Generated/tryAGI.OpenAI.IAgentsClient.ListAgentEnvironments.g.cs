#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List agent environments<br/>
        /// Lists OpenAI-hosted environments owned by the authenticated principal. Requires access to the prewarming beta.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="type">
        /// The hosting type of an execution environment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AgentEnvironmentListResource> ListAgentEnvironmentsAsync(
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = default,
            global::tryAGI.OpenAI.EnvironmentTypeParam? type = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent environments<br/>
        /// Lists OpenAI-hosted environments owned by the authenticated principal. Requires access to the prewarming beta.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="type">
        /// The hosting type of an execution environment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.AgentEnvironmentListResource>> ListAgentEnvironmentsAsResponseAsync(
            long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? after = default,
            global::tryAGI.OpenAI.EnvironmentTypeParam? type = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAgentEnvironmentsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.PublicEnvironmentResource&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// The order in which paginated resources are returned.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="type">
        /// The hosting type of an execution environment.
        /// </param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.PublicEnvironmentResource> ListAgentEnvironmentsAutoPagingAsync(
              long? limit = default,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            global::tryAGI.OpenAI.EnvironmentTypeParam? type = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}