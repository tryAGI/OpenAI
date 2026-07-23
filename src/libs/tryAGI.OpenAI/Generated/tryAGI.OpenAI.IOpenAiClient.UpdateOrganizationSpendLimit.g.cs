#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Create or replace the organization's hard spend limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.OrganizationSpendLimitResource> UpdateOrganizationSpendLimitAsync(

            global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace the organization's hard spend limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.OrganizationSpendLimitResource>> UpdateOrganizationSpendLimitAsResponseAsync(

            global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace the organization's hard spend limit.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.OrganizationSpendLimitResource> UpdateOrganizationSpendLimitAsync(
            int thresholdAmount,
            global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyCurrency currency = default,
            global::tryAGI.OpenAI.UpdateOrganizationSpendLimitBodyInterval interval = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}