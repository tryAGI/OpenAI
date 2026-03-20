#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUserOrganizationRoleAssignmentsClient
    {
        /// <summary>
        /// Lists the organization roles assigned to a user within the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="order"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RoleListResource> ListUserOrganizationRoleAssignmentsAsync(
            string userId,
            int? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.ListUserRoleAssignmentsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}