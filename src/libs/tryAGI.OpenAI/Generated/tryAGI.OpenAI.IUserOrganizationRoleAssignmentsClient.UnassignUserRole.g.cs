#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUserOrganizationRoleAssignmentsClient
    {
        /// <summary>
        /// Unassigns an organization role from a user within the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeletedRoleAssignmentResource> UnassignUserRoleAsync(
            string userId,
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}