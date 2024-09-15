#nullable enable

namespace OpenAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Retrieves a batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Batch> RetrieveBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}