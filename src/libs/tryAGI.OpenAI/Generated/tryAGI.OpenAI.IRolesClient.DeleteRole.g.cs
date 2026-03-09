#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Deletes a custom role from the organization.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RoleDeletedResource> DeleteRoleAsync(
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}