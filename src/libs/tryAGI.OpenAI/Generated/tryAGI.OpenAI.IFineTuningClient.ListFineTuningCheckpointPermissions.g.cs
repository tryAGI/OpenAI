#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List checkpoint permissions<br/>
        /// **NOTE:** This endpoint requires an [admin API key](https://developers.openai.com/api/reference/resources/admin/subresources/organization/subresources/admin_api_keys).<br/>
        /// Organization owners can use this endpoint to view all permissions for a fine-tuned model checkpoint.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="order">
        /// Default Value: descending
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse> ListFineTuningCheckpointPermissionsAsync(
            string fineTunedModelCheckpoint,
            string? projectId = default,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List checkpoint permissions<br/>
        /// **NOTE:** This endpoint requires an [admin API key](https://developers.openai.com/api/reference/resources/admin/subresources/organization/subresources/admin_api_keys).<br/>
        /// Organization owners can use this endpoint to view all permissions for a fine-tuned model checkpoint.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="order">
        /// Default Value: descending
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse>> ListFineTuningCheckpointPermissionsAsResponseAsync(
            string fineTunedModelCheckpoint,
            string? projectId = default,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder? order = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListFineTuningCheckpointPermissionsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.FineTuningCheckpointPermission&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="order">
        /// Default Value: descending
        /// </param>
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.FineTuningCheckpointPermission> ListFineTuningCheckpointPermissionsAutoPagingAsync(
            string fineTunedModelCheckpoint,             string? projectId = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionsOrder? order = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}