#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Updates a group's information.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupResourceWithSuccess> UpdateGroupAsync(
            string groupId,

            global::tryAGI.OpenAI.UpdateGroupBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a group's information.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="name">
        /// New display name for the group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupResourceWithSuccess> UpdateGroupAsync(
            string groupId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}