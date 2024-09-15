#nullable enable

namespace OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Modifies a project in the organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Project> ModifyProjectAsync(
            global::OpenAI.ProjectUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a project in the organization.
        /// </summary>
        /// <param name="name">
        /// The updated name of the project, this name appears in reports.
        /// </param>
        /// <param name="appUseCase">
        /// A description of your business, project, or use case. [Why we need this information](https://help.openai.com/en/articles/9824607-api-platform-verifications).
        /// </param>
        /// <param name="businessWebsite">
        /// Your business URL, or if you don't have one yet, a URL to your LinkedIn or other social media. [Why we need this information](https://help.openai.com/en/articles/9824607-api-platform-verifications).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Project> ModifyProjectAsync(
            string name,
            string? appUseCase = default,
            string? businessWebsite = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}