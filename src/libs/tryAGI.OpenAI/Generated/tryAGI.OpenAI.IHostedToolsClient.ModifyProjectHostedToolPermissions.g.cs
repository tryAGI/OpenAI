#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IHostedToolsClient
    {
        /// <summary>
        /// Updates hosted tool permissions for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectHostedToolPermissions> ModifyProjectHostedToolPermissionsAsync(
            string projectId,

            global::tryAGI.OpenAI.ProjectHostedToolPermissionsUpdateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates hosted tool permissions for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectHostedToolPermissions>> ModifyProjectHostedToolPermissionsAsResponseAsync(
            string projectId,

            global::tryAGI.OpenAI.ProjectHostedToolPermissionsUpdateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates hosted tool permissions for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileSearch">
        /// The file search permission update.
        /// </param>
        /// <param name="webSearch">
        /// The web search permission update.
        /// </param>
        /// <param name="imageGeneration">
        /// The image generation permission update.
        /// </param>
        /// <param name="mcp">
        /// The MCP permission update.
        /// </param>
        /// <param name="codeInterpreter">
        /// The code interpreter permission update.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectHostedToolPermissions> ModifyProjectHostedToolPermissionsAsync(
            string projectId,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? fileSearch = default,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? webSearch = default,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? imageGeneration = default,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? mcp = default,
            global::tryAGI.OpenAI.HostedToolPermissionUpdate? codeInterpreter = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}