#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Create checkpoint permissions<br/>
        /// **NOTE:** Calling this endpoint requires an [admin API key](../admin-api-keys).<br/>
        /// This enables organization owners to share fine-tuned models with other projects in their organization.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft:gpt-4o-mini-2024-07-18:org:weather:B7R9VjQd
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse> CreateFineTuningCheckpointPermissionAsync(
            string fineTunedModelCheckpoint,
            global::tryAGI.OpenAI.CreateFineTuningCheckpointPermissionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create checkpoint permissions<br/>
        /// **NOTE:** Calling this endpoint requires an [admin API key](../admin-api-keys).<br/>
        /// This enables organization owners to share fine-tuned models with other projects in their organization.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft:gpt-4o-mini-2024-07-18:org:weather:B7R9VjQd
        /// </param>
        /// <param name="projectIds">
        /// The project identifiers to grant access to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListFineTuningCheckpointPermissionResponse> CreateFineTuningCheckpointPermissionAsync(
            string fineTunedModelCheckpoint,
            global::System.Collections.Generic.IList<string> projectIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}