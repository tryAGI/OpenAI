#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupUsersClient
    {
        /// <summary>
        /// Adds a user to a group.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupUserAssignment> AddGroupUserAsync(
            string groupId,

            global::tryAGI.OpenAI.CreateGroupUserBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adds a user to a group.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="userId">
        /// Identifier of the user to add to the group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupUserAssignment> AddGroupUserAsync(
            string groupId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}