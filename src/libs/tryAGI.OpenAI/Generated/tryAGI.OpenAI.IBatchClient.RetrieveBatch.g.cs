#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Retrieves a batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Batch> RetrieveBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}