#nullable enable

namespace OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Modifies a user's role in the project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ProjectUser> ModifyProjectUserAsync(
            global::OpenAI.ProjectUserUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a user's role in the project.
        /// </summary>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ProjectUser> ModifyProjectUserAsync(
            global::OpenAI.ProjectUserUpdateRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}