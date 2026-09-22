#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Modify project model permissions<br/>
        /// Updates model permissions for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectModelPermissions> UpdateProjectModelPermissionsAsync(
            string projectId,

            global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify project model permissions<br/>
        /// Updates model permissions for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ProjectModelPermissions>> UpdateProjectModelPermissionsAsResponseAsync(
            string projectId,

            global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify project model permissions<br/>
        /// Updates model permissions for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="mode">
        /// The model permissions mode to apply.
        /// </param>
        /// <param name="modelIds">
        /// The model IDs included in this permissions policy.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectModelPermissions> UpdateProjectModelPermissionsAsync(
            string projectId,
            global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode mode,
            global::System.Collections.Generic.IList<string> modelIds,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}