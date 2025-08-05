#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Add upload part<br/>
        /// Adds a [Part](https://platform.openai.com/docs/api-reference/uploads/part-object) to an [Upload](https://platform.openai.com/docs/api-reference/uploads/object) object. A Part represents a chunk of bytes from the file you are trying to upload. <br/>
        /// Each Part can be at most 64 MB, and you can add Parts until you hit the Upload maximum of 8 GB.<br/>
        /// It is possible to add multiple Parts in parallel. You can decide the intended order of the Parts when you [complete the Upload](https://platform.openai.com/docs/api-reference/uploads/complete).
        /// </summary>
        /// <param name="uploadId">
        /// Example: upload_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UploadPart> AddUploadPartAsync(
            string uploadId,
            global::tryAGI.OpenAI.AddUploadPartRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add upload part<br/>
        /// Adds a [Part](https://platform.openai.com/docs/api-reference/uploads/part-object) to an [Upload](https://platform.openai.com/docs/api-reference/uploads/object) object. A Part represents a chunk of bytes from the file you are trying to upload. <br/>
        /// Each Part can be at most 64 MB, and you can add Parts until you hit the Upload maximum of 8 GB.<br/>
        /// It is possible to add multiple Parts in parallel. You can decide the intended order of the Parts when you [complete the Upload](https://platform.openai.com/docs/api-reference/uploads/complete).
        /// </summary>
        /// <param name="uploadId">
        /// Example: upload_abc123
        /// </param>
        /// <param name="data">
        /// The chunk of bytes for this Part.
        /// </param>
        /// <param name="dataname">
        /// The chunk of bytes for this Part.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.UploadPart> AddUploadPartAsync(
            string uploadId,
            byte[] data,
            string dataname,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}