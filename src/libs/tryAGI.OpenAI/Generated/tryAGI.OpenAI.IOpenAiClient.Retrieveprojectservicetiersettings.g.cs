#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Retrieve project service tier settings<br/>
        /// Retrieve the configured default and enabled service tiers for a project.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectServiceTierSettingsResource> RetrieveprojectservicetiersettingsAsync(
            string projectId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve project service tier settings<br/>
        /// Retrieve the configured default and enabled service tiers for a project.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectServiceTierSettingsResource>> RetrieveprojectservicetiersettingsAsResponseAsync(
            string projectId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}