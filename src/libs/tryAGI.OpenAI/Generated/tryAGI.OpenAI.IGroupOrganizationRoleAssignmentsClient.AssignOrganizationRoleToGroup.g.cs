#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupOrganizationRoleAssignmentsClient
    {
        /// <summary>
        /// Assigns an organization role to a group within the organization.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupRoleAssignment> AssignOrganizationRoleToGroupAsync(
            string groupId,

            global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns an organization role to a group within the organization.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="roleId">
        /// Identifier of the role to assign.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupRoleAssignment> AssignOrganizationRoleToGroupAsync(
            string groupId,
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}