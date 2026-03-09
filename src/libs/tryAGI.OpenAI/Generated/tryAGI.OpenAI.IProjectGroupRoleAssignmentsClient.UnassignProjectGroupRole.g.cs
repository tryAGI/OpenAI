#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectGroupRoleAssignmentsClient
    {
        /// <summary>
        /// Unassigns a project role from a group within a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="groupId"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeletedRoleAssignmentResource> UnassignProjectGroupRoleAsync(
            string projectId,
            string groupId,
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}