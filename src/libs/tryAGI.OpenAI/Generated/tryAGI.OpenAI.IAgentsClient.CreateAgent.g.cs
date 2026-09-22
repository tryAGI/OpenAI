#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an agent<br/>
        /// Creates a reusable agent without storing credentials. See [agent configuration](https://developers.openai.com/api/docs/guides/agents-api/configuration).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AgentResource> CreateAgentAsync(

            global::tryAGI.OpenAI.CreateAgentParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Creates a reusable agent without storing credentials. See [agent configuration](https://developers.openai.com/api/docs/guides/agents-api/configuration).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.AgentResource>> CreateAgentAsResponseAsync(

            global::tryAGI.OpenAI.CreateAgentParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent<br/>
        /// Creates a reusable agent without storing credentials. See [agent configuration](https://developers.openai.com/api/docs/guides/agents-api/configuration).
        /// </summary>
        /// <param name="metadata">
        /// Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters. Omission or null defaults to an empty map.
        /// </param>
        /// <param name="name">
        /// A human-readable name for the agent. Omission or null leaves the agent unnamed.
        /// </param>
        /// <param name="model">
        /// The model to use for the agent. The requested model name is preserved.
        /// </param>
        /// <param name="reasoning">
        /// Configuration for model reasoning. Omission uses the model's default effort.
        /// </param>
        /// <param name="text">
        /// Configuration for generated text. Defaults to the `text` format and medium verbosity.
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used for model requests. Defaults to `auto`.
        /// </param>
        /// <param name="instructions">
        /// Additional instructions appended to the agent's default base instructions. Omit or set to null to add no custom instructions.
        /// </param>
        /// <param name="tools">
        /// Tools available to the agent. Defaults to an empty list.
        /// </param>
        /// <param name="multiAgent">
        /// Configuration for creating and coordinating subagents. Subagent tools are disabled by default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AgentResource> CreateAgentAsync(
            string model,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? name = default,
            global::tryAGI.OpenAI.ReasoningParam? reasoning = default,
            global::tryAGI.OpenAI.TextParam? text = default,
            global::tryAGI.OpenAI.ServiceTierParam? serviceTier = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>? tools = default,
            global::tryAGI.OpenAI.MultiAgentConfigCurrentParam? multiAgent = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}