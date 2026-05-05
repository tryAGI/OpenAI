#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create a ChatKit session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ChatSessionResource> CreateChatKitSessionAsync(

            global::tryAGI.OpenAI.CreateChatSessionBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a ChatKit session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ChatSessionResource>> CreateChatKitSessionAsResponseAsync(

            global::tryAGI.OpenAI.CreateChatSessionBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a ChatKit session.
        /// </summary>
        /// <param name="workflow">
        /// Workflow that powers the session.
        /// </param>
        /// <param name="user">
        /// A free-form string that identifies your end user; ensures this Session can access other objects that have the same `user` scope.
        /// </param>
        /// <param name="expiresAfter">
        /// Optional override for session expiration timing in seconds from creation. Defaults to 10 minutes.
        /// </param>
        /// <param name="rateLimits">
        /// Optional override for per-minute request limits. When omitted, defaults to 10.
        /// </param>
        /// <param name="chatkitConfiguration">
        /// Optional overrides for ChatKit runtime configuration features
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ChatSessionResource> CreateChatKitSessionAsync(
            global::tryAGI.OpenAI.WorkflowParam workflow,
            string user,
            global::tryAGI.OpenAI.ExpiresAfterParam? expiresAfter = default,
            global::tryAGI.OpenAI.RateLimitsParam? rateLimits = default,
            global::tryAGI.OpenAI.ChatkitConfigurationParam? chatkitConfiguration = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}