#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project<br/>
        /// Create a new project in the organization. Projects can be created and archived, but cannot be deleted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Project> CreateProjectAsync(

            global::tryAGI.OpenAI.ProjectCreateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Create a new project in the organization. Projects can be created and archived, but cannot be deleted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.Project>> CreateProjectAsResponseAsync(

            global::tryAGI.OpenAI.ProjectCreateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Create a new project in the organization. Projects can be created and archived, but cannot be deleted.
        /// </summary>
        /// <param name="name">
        /// The friendly name of the project, this name appears in reports.
        /// </param>
        /// <param name="residency">
        /// Create the project with the specified residency configuration. Your organization must have access to the requested residency configuration in order to use it. See [data residency controls](https://developers.openai.com/api/docs/guides/your-data#data-residency-controls) to review the functionality and limitations of setting this field.
        /// </param>
        /// <param name="externalKeyId">
        /// External key ID to associate with the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Project> CreateProjectAsync(
            string name,
            global::tryAGI.OpenAI.PublicProjectResidency? residency = default,
            string? externalKeyId = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}