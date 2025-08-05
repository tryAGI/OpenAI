#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve user<br/>
        /// Retrieves a user by their identifier.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.User> RetrieveUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}