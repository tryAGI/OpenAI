#nullable enable

namespace OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Archives a project in the organization. Archived projects cannot be used or updated.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Project> ArchiveProjectAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}