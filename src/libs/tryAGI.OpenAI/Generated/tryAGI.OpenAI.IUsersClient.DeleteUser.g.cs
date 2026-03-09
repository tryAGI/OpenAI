#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Deletes a user from the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UserDeleteResponse> DeleteUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}