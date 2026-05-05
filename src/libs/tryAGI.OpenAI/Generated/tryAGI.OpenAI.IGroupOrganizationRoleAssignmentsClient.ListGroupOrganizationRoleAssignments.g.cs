#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupOrganizationRoleAssignmentsClient
    {
        /// <summary>
        /// Lists the organization roles assigned to a group within the organization.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="order"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RoleListResource> ListGroupOrganizationRoleAssignmentsAsync(
            string groupId,
            int? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists the organization roles assigned to a group within the organization.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="order"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.RoleListResource>> ListGroupOrganizationRoleAssignmentsAsResponseAsync(
            string groupId,
            int? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.ListGroupRoleAssignmentsOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}