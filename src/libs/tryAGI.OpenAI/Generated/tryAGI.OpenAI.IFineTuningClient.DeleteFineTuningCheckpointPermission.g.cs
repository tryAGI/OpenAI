#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// **NOTE:** This endpoint requires an [admin API key](../admin-api-keys).<br/>
        /// Organization owners can use this endpoint to delete a permission for a fine-tuned model checkpoint.
        /// </summary>
        /// <param name="permissionId">
        /// Example: cp_zc4Q7MP6XxulcVzj4MZdwsAB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponse> DeleteFineTuningCheckpointPermissionAsync(
            string permissionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}