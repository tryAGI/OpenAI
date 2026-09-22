#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create an agent environment template<br/>
        /// Creates reusable environment configuration without returning confidential setup commands or environment values. See [reusing a hosted setup](https://developers.openai.com/api/docs/guides/agents-api/tools#reuse-a-hosted-plugin-setup).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EnvironmentTemplateResource> CreateAgentEnvironmentTemplateAsync(

            global::tryAGI.OpenAI.CreateEnvironmentTemplateParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent environment template<br/>
        /// Creates reusable environment configuration without returning confidential setup commands or environment values. See [reusing a hosted setup](https://developers.openai.com/api/docs/guides/agents-api/tools#reuse-a-hosted-plugin-setup).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.EnvironmentTemplateResource>> CreateAgentEnvironmentTemplateAsResponseAsync(

            global::tryAGI.OpenAI.CreateEnvironmentTemplateParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent environment template<br/>
        /// Creates reusable environment configuration without returning confidential setup commands or environment values. See [reusing a hosted setup](https://developers.openai.com/api/docs/guides/agents-api/tools#reuse-a-hosted-plugin-setup).
        /// </summary>
        /// <param name="packages">
        /// Packages to install in the environment. Defaults to empty package lists.
        /// </param>
        /// <param name="setupCommands">
        /// Ordered, confidential setup commands. Command bodies are never returned.
        /// </param>
        /// <param name="network">
        /// Network access policy for the environment. Defaults to disabled for GA requests and enabled for alpha/beta requests.
        /// </param>
        /// <param name="env">
        /// Environment variables made available to the agent.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that contain capabilities exposed to the agent. Defaults to an empty list.
        /// </param>
        /// <param name="skills">
        /// Skills referenced by ID or provided as inline ZIP archives. Defaults to an empty list.
        /// </param>
        /// <param name="plugins">
        /// Plugins provided as inline ZIP archives. Defaults to an empty list.
        /// </param>
        /// <param name="files">
        /// Files available before the agent starts. Defaults to an empty list.
        /// </param>
        /// <param name="name">
        /// An optional human-readable display name for the template.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EnvironmentTemplateResource> CreateAgentEnvironmentTemplateAsync(
            global::tryAGI.OpenAI.EnvironmentPackagesParam? packages = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? setupCommands = default,
            global::tryAGI.OpenAI.NetworkPolicyParam? network = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            global::System.Collections.Generic.IList<string>? capabilityDirectories = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? skills = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? plugins = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? files = default,
            string? name = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}