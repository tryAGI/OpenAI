#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUserOrganizationRoleAssignmentsClient
    {
        /// <summary>
        /// Assigns an organization role to a user within the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UserRoleAssignment> AssignUserRoleAsync(
            string userId,

            global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns an organization role to a user within the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleId">
        /// Identifier of the role to assign.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UserRoleAssignment> AssignUserRoleAsync(
            string userId,
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}