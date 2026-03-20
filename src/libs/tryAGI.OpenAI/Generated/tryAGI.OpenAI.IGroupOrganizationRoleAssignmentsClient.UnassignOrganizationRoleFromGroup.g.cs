#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupOrganizationRoleAssignmentsClient
    {
        /// <summary>
        /// Unassigns an organization role from a group within the organization.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeletedRoleAssignmentResource> UnassignOrganizationRoleFromGroupAsync(
            string groupId,
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}