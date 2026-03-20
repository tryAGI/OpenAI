#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Creates a custom role for the organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Role> CreateOrganizationRoleAsync(

            global::tryAGI.OpenAI.PublicCreateOrganizationRoleBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a custom role for the organization.
        /// </summary>
        /// <param name="roleName">
        /// Unique name for the role.
        /// </param>
        /// <param name="permissions">
        /// Permissions to grant to the role.
        /// </param>
        /// <param name="description">
        /// Optional description of the role.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Role> CreateOrganizationRoleAsync(
            string roleName,
            global::System.Collections.Generic.IList<string> permissions,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}