#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupUsersClient
    {
        /// <summary>
        /// Removes a user from a group.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupUserDeletedResource> RemoveGroupUserAsync(
            string groupId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}