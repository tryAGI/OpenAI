#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an agent session<br/>
        /// Creates a managed agent session, optionally submits initial input, and returns the session or streams its events when stream is true. See [running sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SessionResource> CreateAgentSessionAsync(

            global::tryAGI.OpenAI.CreateAgentSessionParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent session<br/>
        /// Creates a managed agent session, optionally submits initial input, and returns the session or streams its events when stream is true. See [running sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.SessionResource>> CreateAgentSessionAsResponseAsync(

            global::tryAGI.OpenAI.CreateAgentSessionParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent session<br/>
        /// Creates a managed agent session, optionally submits initial input, and returns the session or streams its events when stream is true. See [running sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions).
        /// </summary>
        /// <param name="metadata">
        /// Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Omission or null defaults to an empty map.
        /// </param>
        /// <param name="agent">
        /// Agent configuration. With `agent_id`, supplied fields override the saved agent for this session. Without `agent_id`, `model` is required.
        /// </param>
        /// <param name="agentId">
        /// The ID of a saved reusable agent. Omit `agent` to use its configuration unchanged.
        /// </param>
        /// <param name="environment">
        /// An inline execution environment or a reference to an environment template.
        /// </param>
        /// <param name="vaultIds">
        /// The IDs of vaults made available to the session.
        /// </param>
        /// <param name="input">
        /// Initial input to submit when the session is created. A string is shorthand for a single user message. Required when `environment.type` is `none`, or when `stream` is `true` for an environment that is not `self_hosted`; optional for self-hosted and non-streaming execution environments.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SessionResource> CreateAgentSessionAsync(
            global::tryAGI.OpenAI.EnvironmentParam environment,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::tryAGI.OpenAI.SessionAgentConfigParam? agent = default,
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? vaultIds = default,
            global::tryAGI.OpenAI.CreateSessionInputParam? input = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}