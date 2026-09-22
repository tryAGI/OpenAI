#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List agent session artifacts<br/>
        /// Lists immutable artifacts published by completed hosted session turns. See [session artifacts](https://developers.openai.com/api/docs/guides/agents-api/environments/files#openai-hosted-artifacts).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="order">
        /// The order in which paginated resources are returned.
        /// </param>
        /// <param name="environmentId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SessionArtifactListResource> ListAgentSessionArtifactsAsync(
            string sessionId,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? environmentId = default,
            long? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent session artifacts<br/>
        /// Lists immutable artifacts published by completed hosted session turns. See [session artifacts](https://developers.openai.com/api/docs/guides/agents-api/environments/files#openai-hosted-artifacts).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="order">
        /// The order in which paginated resources are returned.
        /// </param>
        /// <param name="environmentId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.SessionArtifactListResource>> ListAgentSessionArtifactsAsResponseAsync(
            string sessionId,
            global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? environmentId = default,
            long? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAgentSessionArtifactsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.SessionArtifactResource&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="order">
        /// The order in which paginated resources are returned.
        /// </param>
        /// <param name="environmentId"></param>
        /// <param name="limit"></param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.SessionArtifactResource> ListAgentSessionArtifactsAutoPagingAsync(
            string sessionId,             global::tryAGI.OpenAI.ListOrderParam? order = default,
            string? environmentId = default,
            long? limit = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}