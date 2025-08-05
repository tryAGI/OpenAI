#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Modify project<br/>
        /// Modifies a project in the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Project> ModifyProjectAsync(
            string projectId,
            global::tryAGI.OpenAI.ProjectUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modify project<br/>
        /// Modifies a project in the organization.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// The updated name of the project, this name appears in reports.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Project> ModifyProjectAsync(
            string projectId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}