#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List fine-tuning events<br/>
        /// Get status updates for a fine-tuning job.
        /// </summary>
        /// <param name="fineTuningJobId">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListFineTuningJobEventsResponse> ListFineTuningEventsAsync(
            string fineTuningJobId,
            string? after = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}