#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectUserRoleAssignmentsClient
    {
        /// <summary>
        /// Unassigns a project role from a user within a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeletedRoleAssignmentResource> UnassignProjectUserRoleAsync(
            string projectId,
            string userId,
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}