#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Update project service tier settings<br/>
        /// Update the default or enabled service tiers atomically. Supply at least one field. Omitted fields keep their current values.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectServiceTierSettingsResource> UpdateprojectservicetiersettingsAsync(
            string projectId,

            global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project service tier settings<br/>
        /// Update the default or enabled service tiers atomically. Supply at least one field. Omitted fields keep their current values.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectServiceTierSettingsResource>> UpdateprojectservicetiersettingsAsResponseAsync(
            string projectId,

            global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project service tier settings<br/>
        /// Update the default or enabled service tiers atomically. Supply at least one field. Omitted fields keep their current values.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="default">
        /// Default tier for requests that omit service_tier or use auto.
        /// </param>
        /// <param name="enabledTiers">
        /// Additional service tiers enabled for this project. "all" includes future tiers. An empty array allows only Standard. Organization policy and eligibility still apply.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectServiceTierSettingsResource> UpdateprojectservicetiersettingsAsync(
            string projectId,
            global::tryAGI.OpenAI.ProjectDefaultServiceTier? @default = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.UpdateProjectServiceTierSettingsBodyEnabledTiers?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectOptionalServiceTier>>? enabledTiers = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}