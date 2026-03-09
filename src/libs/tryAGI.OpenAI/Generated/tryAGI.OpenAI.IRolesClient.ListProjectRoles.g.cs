#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRolesClient
    {
        /// <summary>
        /// Lists the roles configured for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="after"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.PublicRoleListResource> ListProjectRolesAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.ListProjectRolesOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}