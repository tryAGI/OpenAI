#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an agent environment<br/>
        /// Creates an OpenAI-hosted environment before creating a session. Requires access to the prewarming beta.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PublicEnvironmentResource> CreateAgentEnvironmentAsync(

            global::tryAGI.OpenAI.CreateAgentEnvironmentParams request,
            string? idempotencyKey = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent environment<br/>
        /// Creates an OpenAI-hosted environment before creating a session. Requires access to the prewarming beta.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.PublicEnvironmentResource>> CreateAgentEnvironmentAsResponseAsync(

            global::tryAGI.OpenAI.CreateAgentEnvironmentParams request,
            string? idempotencyKey = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent environment<br/>
        /// Creates an OpenAI-hosted environment before creating a session. Requires access to the prewarming beta.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="environment">
        /// The required hosting type and its configuration.
        /// </param>
        /// <param name="vaultIds">
        /// The IDs of up to 10 vaults made available to an OpenAI-hosted environment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PublicEnvironmentResource> CreateAgentEnvironmentAsync(
            global::tryAGI.OpenAI.CreateEnvironmentParamOpenaiHosted environment,
            string? idempotencyKey = default,
            global::System.Collections.Generic.IList<string>? vaultIds = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}