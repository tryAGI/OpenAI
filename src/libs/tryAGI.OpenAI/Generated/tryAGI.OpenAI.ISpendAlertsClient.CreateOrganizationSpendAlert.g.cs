#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISpendAlertsClient
    {
        /// <summary>
        /// Creates an organization spend alert.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.OrganizationSpendAlert> CreateOrganizationSpendAlertAsync(

            global::tryAGI.OpenAI.CreateSpendAlertBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an organization spend alert.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.OrganizationSpendAlert>> CreateOrganizationSpendAlertAsResponseAsync(

            global::tryAGI.OpenAI.CreateSpendAlertBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an organization spend alert.
        /// </summary>
        /// <param name="thresholdAmount">
        /// The alert threshold amount, in cents.
        /// </param>
        /// <param name="currency">
        /// The currency for the threshold amount.
        /// </param>
        /// <param name="interval">
        /// The time interval for evaluating spend against the threshold.
        /// </param>
        /// <param name="notificationChannel">
        /// Email notification settings for a spend alert.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.OrganizationSpendAlert> CreateOrganizationSpendAlertAsync(
            int thresholdAmount,
            global::tryAGI.OpenAI.SpendAlertNotificationChannel notificationChannel,
            global::tryAGI.OpenAI.CreateSpendAlertBodyCurrency currency = default,
            global::tryAGI.OpenAI.CreateSpendAlertBodyInterval interval = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}