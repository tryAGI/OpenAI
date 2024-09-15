#nullable enable

namespace OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Deletes a user from the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ProjectUserDeleteResponse> DeleteProjectUserAsync(
            string projectId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}