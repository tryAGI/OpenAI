#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an agent environment template<br/>
        /// Updates reusable environment configuration without returning confidential values. See [reusing a hosted setup](https://developers.openai.com/api/docs/guides/agents-api/tools#reuse-a-hosted-plugin-setup).
        /// </summary>
        /// <param name="environmentTemplateId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EnvironmentTemplateResource> UpdateAgentEnvironmentTemplateAsync(
            string environmentTemplateId,

            global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent environment template<br/>
        /// Updates reusable environment configuration without returning confidential values. See [reusing a hosted setup](https://developers.openai.com/api/docs/guides/agents-api/tools#reuse-a-hosted-plugin-setup).
        /// </summary>
        /// <param name="environmentTemplateId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.EnvironmentTemplateResource>> UpdateAgentEnvironmentTemplateAsResponseAsync(
            string environmentTemplateId,

            global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent environment template<br/>
        /// Updates reusable environment configuration without returning confidential values. See [reusing a hosted setup](https://developers.openai.com/api/docs/guides/agents-api/tools#reuse-a-hosted-plugin-setup).
        /// </summary>
        /// <param name="environmentTemplateId"></param>
        /// <param name="name">
        /// A replacement human-readable display name, or `null` to clear the name.
        /// </param>
        /// <param name="packages">
        /// Packages installed before the runtime network policy applies.
        /// </param>
        /// <param name="setupCommands">
        /// Replacement confidential setup commands, never included in returned resources.
        /// </param>
        /// <param name="network">
        /// Network access available after setup completes. Omit to preserve the current policy, or pass `null` to reset to disabled for GA requests or enabled for alpha/beta requests.
        /// </param>
        /// <param name="env">
        /// Replacement confidential environment values.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that expose capabilities to the agent.
        /// </param>
        /// <param name="skills">
        /// Replacement skill configuration installed for each new session.
        /// </param>
        /// <param name="plugins">
        /// Replacement plugin configuration installed for each new session.
        /// </param>
        /// <param name="files">
        /// Replacement file configuration materialized for each new session.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EnvironmentTemplateResource> UpdateAgentEnvironmentTemplateAsync(
            string environmentTemplateId,
            string? name = default,
            global::tryAGI.OpenAI.EnvironmentPackagesParam? packages = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>? setupCommands = default,
            global::tryAGI.OpenAI.NetworkPolicyParam? network = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            global::System.Collections.Generic.IList<string>? capabilityDirectories = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>? skills = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>? plugins = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>? files = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}