#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Updates an existing project role.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="roleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Role> UpdateProjectRoleAsync(
            string projectId,
            string roleId,

            global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing project role.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="roleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.Role>> UpdateProjectRoleAsResponseAsync(
            string projectId,
            string roleId,

            global::tryAGI.OpenAI.PublicUpdateOrganizationRoleBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing project role.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="roleId"></param>
        /// <param name="permissions">
        /// Updated set of permissions for the role.
        /// </param>
        /// <param name="description">
        /// New description for the role.
        /// </param>
        /// <param name="roleName">
        /// New name for the role.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Role> UpdateProjectRoleAsync(
            string projectId,
            string roleId,
            global::System.Collections.Generic.IList<string>? permissions = default,
            string? description = default,
            string? roleName = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}