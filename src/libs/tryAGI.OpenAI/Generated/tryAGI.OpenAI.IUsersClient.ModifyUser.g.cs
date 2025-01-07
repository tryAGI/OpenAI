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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.User> ModifyUserAsync(
            string userId,
            global::tryAGI.OpenAI.UserRoleUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a user's role in the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.User> ModifyUserAsync(
            string userId,
            global::tryAGI.OpenAI.UserRoleUpdateRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}