#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectUserRoleAssignmentsClient
    {
        /// <summary>
        /// Assigns a project role to a user within a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UserRoleAssignment> AssignProjectRoleToUserAsync(
            string projectId,
            string userId,

            global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns a project role to a user within a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="roleId">
        /// Identifier of the role to assign.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UserRoleAssignment> AssignProjectRoleToUserAsync(
            string projectId,
            string userId,
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}