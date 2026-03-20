#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectGroupsClient
    {
        /// <summary>
        /// Grants a group access to a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectGroup> AddProjectGroupAsync(
            string projectId,

            global::tryAGI.OpenAI.InviteProjectGroupBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grants a group access to a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="groupId">
        /// Identifier of the group to add to the project.
        /// </param>
        /// <param name="role">
        /// Identifier of the project role to grant to the group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectGroup> AddProjectGroupAsync(
            string projectId,
            string groupId,
            string role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}