#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Delete checkpoint permission<br/>
        /// **NOTE:** This endpoint requires an [admin API key](https://developers.openai.com/api/reference/resources/admin/subresources/organization/subresources/admin_api_keys).<br/>
        /// Organization owners can use this endpoint to delete a permission for a fine-tuned model checkpoint.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft:gpt-4o-mini-2024-07-18:org:weather:B7R9VjQd
        /// </param>
        /// <param name="permissionId">
        /// Example: cp_zc4Q7MP6XxulcVzj4MZdwsAB
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse> DeleteFineTuningCheckpointPermissionAsync(
            string fineTunedModelCheckpoint,
            string permissionId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete checkpoint permission<br/>
        /// **NOTE:** This endpoint requires an [admin API key](https://developers.openai.com/api/reference/resources/admin/subresources/organization/subresources/admin_api_keys).<br/>
        /// Organization owners can use this endpoint to delete a permission for a fine-tuned model checkpoint.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft:gpt-4o-mini-2024-07-18:org:weather:B7R9VjQd
        /// </param>
        /// <param name="permissionId">
        /// Example: cp_zc4Q7MP6XxulcVzj4MZdwsAB
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse>> DeleteFineTuningCheckpointPermissionAsResponseAsync(
            string fineTunedModelCheckpoint,
            string permissionId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}