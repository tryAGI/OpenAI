#nullable enable

namespace OpenAI
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Deletes a user from the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.UserDeleteResponse> DeleteUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}