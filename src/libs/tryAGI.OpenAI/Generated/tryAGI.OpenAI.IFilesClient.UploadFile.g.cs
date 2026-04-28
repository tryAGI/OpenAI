#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file that can be used across various endpoints. Individual files<br/>
        /// can be up to 512 MB, and each project can store up to 2.5 TB of files in<br/>
        /// total. There is no organization-wide storage limit. Uploads to this<br/>
        /// endpoint are rate-limited to 1,000 requests per minute per authenticated<br/>
        /// user.<br/>
        /// - The Assistants API supports files up to 2 million tokens and of specific<br/>
        ///   file types. See the [Assistants Tools guide](/docs/assistants/tools) for<br/>
        ///   details.<br/>
        /// - The Fine-tuning API only supports `.jsonl` files. The input also has<br/>
        ///   certain required formats for fine-tuning<br/>
        ///   [chat](/docs/api-reference/fine-tuning/chat-input) or<br/>
        ///   [completions](/docs/api-reference/fine-tuning/completions-input) models.<br/>
        /// - The Batch API only supports `.jsonl` files up to 200 MB in size. The input<br/>
        ///   also has a specific required<br/>
        ///   [format](/docs/api-reference/batch/request-input).<br/>
        /// - For Retrieval or `file_search` ingestion, upload files here first. If<br/>
        ///   you need to attach multiple uploaded files to the same vector store, use<br/>
        ///   [`/vector_stores/{vector_store_id}/file_batches`](/docs/api-reference/vector-stores-file-batches/createBatch)<br/>
        ///   instead of attaching them one by one. Vector store attachment has separate<br/>
        ///   limits from file upload, including 2,000 attached files per minute per<br/>
        ///   organization.<br/>
        /// Please [contact us](https://help.openai.com/) if you need to increase these<br/>
        /// storage limits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.OpenAIFile> UploadFileAsync(

            global::tryAGI.OpenAI.CreateFileRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file that can be used across various endpoints. Individual files<br/>
        /// can be up to 512 MB, and each project can store up to 2.5 TB of files in<br/>
        /// total. There is no organization-wide storage limit. Uploads to this<br/>
        /// endpoint are rate-limited to 1,000 requests per minute per authenticated<br/>
        /// user.<br/>
        /// - The Assistants API supports files up to 2 million tokens and of specific<br/>
        ///   file types. See the [Assistants Tools guide](/docs/assistants/tools) for<br/>
        ///   details.<br/>
        /// - The Fine-tuning API only supports `.jsonl` files. The input also has<br/>
        ///   certain required formats for fine-tuning<br/>
        ///   [chat](/docs/api-reference/fine-tuning/chat-input) or<br/>
        ///   [completions](/docs/api-reference/fine-tuning/completions-input) models.<br/>
        /// - The Batch API only supports `.jsonl` files up to 200 MB in size. The input<br/>
        ///   also has a specific required<br/>
        ///   [format](/docs/api-reference/batch/request-input).<br/>
        /// - For Retrieval or `file_search` ingestion, upload files here first. If<br/>
        ///   you need to attach multiple uploaded files to the same vector store, use<br/>
        ///   [`/vector_stores/{vector_store_id}/file_batches`](/docs/api-reference/vector-stores-file-batches/createBatch)<br/>
        ///   instead of attaching them one by one. Vector store attachment has separate<br/>
        ///   limits from file upload, including 2,000 attached files per minute per<br/>
        ///   organization.<br/>
        /// Please [contact us](https://help.openai.com/) if you need to increase these<br/>
        /// storage limits.
        /// </summary>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file. One of:<br/>
        /// - `assistants`: Used in the Assistants API<br/>
        /// - `batch`: Used in the Batch API<br/>
        /// - `fine-tune`: Used for fine-tuning<br/>
        /// - `vision`: Images used for vision fine-tuning<br/>
        /// - `user_data`: Flexible file type for any purpose<br/>
        /// - `evals`: Used for eval data sets
        /// </param>
        /// <param name="expiresAfter">
        /// The expiration policy for a file. By default, files with `purpose=batch` expire after 30 days and all other files are persisted until they are manually deleted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.OpenAIFile> UploadFileAsync(
            byte[] file,
            string filename,
            global::tryAGI.OpenAI.CreateFileRequestPurpose purpose,
            global::tryAGI.OpenAI.FileExpirationAfter? expiresAfter = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}