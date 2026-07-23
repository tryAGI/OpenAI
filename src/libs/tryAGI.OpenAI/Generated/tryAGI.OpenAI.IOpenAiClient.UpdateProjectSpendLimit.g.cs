#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create or replace a project's hard spend limit.
        /// </summary>
        /// <param name="projectId">
        /// Example: proj_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectSpendLimitResource> UpdateProjectSpendLimitAsync(
            string projectId,

            global::tryAGI.OpenAI.UpdateProjectSpendLimitBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace a project's hard spend limit.
        /// </summary>
        /// <param name="projectId">
        /// Example: proj_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectSpendLimitResource>> UpdateProjectSpendLimitAsResponseAsync(
            string projectId,

            global::tryAGI.OpenAI.UpdateProjectSpendLimitBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace a project's hard spend limit.
        /// </summary>
        /// <param name="projectId">
        /// Example: proj_123
        /// </param>
        /// <param name="thresholdAmount">
        /// The hard spend limit amount, in cents.
        /// </param>
        /// <param name="currency">
        /// The currency for the threshold amount. Currently, only `USD` is supported.
        /// </param>
        /// <param name="interval">
        /// The time interval for evaluating spend against the threshold. Currently, only `month` is supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectSpendLimitResource> UpdateProjectSpendLimitAsync(
            string projectId,
            int thresholdAmount,
            global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyCurrency currency = default,
            global::tryAGI.OpenAI.UpdateProjectSpendLimitBodyInterval interval = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}