#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create batch<br/>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Batch> CreateBatchAsync(
            global::tryAGI.OpenAI.CreateBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create batch<br/>
        /// Creates and executes a batch from an uploaded file of requests
        /// </summary>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed. Currently only `24h` is supported.
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to be used for all requests in the batch. Currently `/v1/responses`, `/v1/chat/completions`, `/v1/embeddings`, and `/v1/completions` are supported. Note that `/v1/embeddings` batches are also restricted to a maximum of 50,000 embedding inputs across all requests in the batch.
        /// </param>
        /// <param name="inputFileId">
        /// The ID of an uploaded file that contains requests for the new batch.<br/>
        /// See [upload file](https://platform.openai.com/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your input file must be formatted as a [JSONL file](https://platform.openai.com/docs/api-reference/batch/request-input), and must be uploaded with the purpose `batch`. The file can contain up to 50,000 requests, and can be up to 200 MB in size.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="outputExpiresAfter">
        /// The expiration policy for the output and/or error file that are generated for a batch.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Batch> CreateBatchAsync(
            global::tryAGI.OpenAI.CreateBatchRequestEndpoint endpoint,
            string inputFileId,
            global::tryAGI.OpenAI.CreateBatchRequestCompletionWindow completionWindow = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::tryAGI.OpenAI.BatchFileExpirationAfter? outputExpiresAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}