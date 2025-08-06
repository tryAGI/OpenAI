#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project user<br/>
        /// Adds a user to the project. Users must already be members of the organization to be added to a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectUser> CreateProjectUserAsync(
            string projectId,
            global::tryAGI.OpenAI.ProjectUserCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create project user<br/>
        /// Adds a user to the project. Users must already be members of the organization to be added to a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="userId">
        /// The ID of the user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectUser> CreateProjectUserAsync(
            string projectId,
            global::tryAGI.OpenAI.ProjectUserCreateRequestRole role,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}