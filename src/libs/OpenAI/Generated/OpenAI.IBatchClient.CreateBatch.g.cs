#nullable enable

namespace OpenAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Batch> CreateBatchAsync(
            global::OpenAI.CreateBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="inputFileId">
        /// The ID of an uploaded file that contains requests for the new batch.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your input file must be formatted as a [JSONL file](/docs/api-reference/batch/request-input), and must be uploaded with the purpose `batch`. The file can contain up to 50,000 requests, and can be up to 100 MB in size.
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions`, `/v1/embeddings`, and `/v1/completions` are supported. Note that `/v1/embeddings` batches are also restricted to a maximum of 50,000 embedding inputs across all requests in the batch.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed. Currently only `24h` is supported.
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata for the batch.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Batch> CreateBatchAsync(
            string inputFileId,
            global::OpenAI.CreateBatchRequestEndpoint endpoint,
            global::OpenAI.CreateBatchRequestCompletionWindow completionWindow = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}