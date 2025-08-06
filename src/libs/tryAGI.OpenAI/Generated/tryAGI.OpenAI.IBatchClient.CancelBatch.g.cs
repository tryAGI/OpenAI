#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Cancel batch<br/>
        /// Cancels an in-progress batch. The batch will be in status `cancelling` for up to 10 minutes, before changing to `cancelled`, where it will have partial results (if any) available in the output file.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Batch> CancelBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}