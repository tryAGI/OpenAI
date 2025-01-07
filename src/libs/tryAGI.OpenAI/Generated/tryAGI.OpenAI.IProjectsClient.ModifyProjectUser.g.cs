#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Modifies a user's role in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectUser> ModifyProjectUserAsync(
            string projectId,
            string userId,
            global::tryAGI.OpenAI.ProjectUserUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a user's role in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectUser> ModifyProjectUserAsync(
            string projectId,
            string userId,
            global::tryAGI.OpenAI.ProjectUserUpdateRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}