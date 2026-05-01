#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Modifies a user's role in the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.User> ModifyUserAsync(
            string userId,

            global::tryAGI.OpenAI.UserRoleUpdateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modifies a user's role in the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="roleId">
        /// Role ID to assign to the user.
        /// </param>
        /// <param name="technicalLevel">
        /// Technical level metadata.
        /// </param>
        /// <param name="developerPersona">
        /// Developer persona metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.User> ModifyUserAsync(
            string userId,
            string? role = default,
            string? roleId = default,
            string? technicalLevel = default,
            string? developerPersona = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}