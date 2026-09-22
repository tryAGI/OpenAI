#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUserOrganizationRoleAssignmentsClient
    {
        /// <summary>
        /// Assign organization role to user<br/>
        /// Assigns an organization role to a user within the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UserRoleAssignment> AssignUserRoleAsync(
            string userId,

            global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign organization role to user<br/>
        /// Assigns an organization role to a user within the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.UserRoleAssignment>> AssignUserRoleAsResponseAsync(
            string userId,

            global::tryAGI.OpenAI.PublicAssignOrganizationGroupRoleBody request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign organization role to user<br/>
        /// Assigns an organization role to a user within the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleId">
        /// Identifier of the role to assign.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UserRoleAssignment> AssignUserRoleAsync(
            string userId,
            string roleId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}