#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISpendAlertsClient
    {
        /// <summary>
        /// Deletes a project spend alert.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="alertId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectSpendAlertDeletedResource> DeleteProjectSpendAlertAsync(
            string projectId,
            string alertId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a project spend alert.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="alertId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectSpendAlertDeletedResource>> DeleteProjectSpendAlertAsResponseAsync(
            string projectId,
            string alertId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}