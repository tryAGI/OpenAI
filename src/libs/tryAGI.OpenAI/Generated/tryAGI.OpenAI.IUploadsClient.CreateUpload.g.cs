#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IUploadsClient
    {
        /// <summary>
        /// Create upload<br/>
        /// Creates an intermediate [Upload](https://developers.openai.com/api/reference/resources/uploads) object<br/>
        /// that you can add [Parts](https://developers.openai.com/api/reference/resources/uploads/subresources/parts) to.<br/>
        /// Currently, an Upload can accept at most 8 GB in total and expires after an<br/>
        /// hour after you create it.<br/>
        /// Once you complete the Upload, we will create a<br/>
        /// [File](https://developers.openai.com/api/reference/resources/files) object that contains all the parts<br/>
        /// you uploaded. This File is usable in the rest of our platform as a regular<br/>
        /// File object.<br/>
        /// For certain `purpose` values, the correct `mime_type` must be specified.<br/>
        /// Please refer to documentation for the<br/>
        /// [supported MIME types for your use case](https://developers.openai.com/api/docs/guides/tools-file-search#supported-files).<br/>
        /// For guidance on the proper filename extensions for each purpose, please<br/>
        /// follow the documentation on [creating a<br/>
        /// File](https://developers.openai.com/api/reference/resources/files/methods/create).<br/>
        /// Returns the Upload object with status `pending`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Upload> CreateUploadAsync(

            global::tryAGI.OpenAI.CreateUploadRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create upload<br/>
        /// Creates an intermediate [Upload](https://developers.openai.com/api/reference/resources/uploads) object<br/>
        /// that you can add [Parts](https://developers.openai.com/api/reference/resources/uploads/subresources/parts) to.<br/>
        /// Currently, an Upload can accept at most 8 GB in total and expires after an<br/>
        /// hour after you create it.<br/>
        /// Once you complete the Upload, we will create a<br/>
        /// [File](https://developers.openai.com/api/reference/resources/files) object that contains all the parts<br/>
        /// you uploaded. This File is usable in the rest of our platform as a regular<br/>
        /// File object.<br/>
        /// For certain `purpose` values, the correct `mime_type` must be specified.<br/>
        /// Please refer to documentation for the<br/>
        /// [supported MIME types for your use case](https://developers.openai.com/api/docs/guides/tools-file-search#supported-files).<br/>
        /// For guidance on the proper filename extensions for each purpose, please<br/>
        /// follow the documentation on [creating a<br/>
        /// File](https://developers.openai.com/api/reference/resources/files/methods/create).<br/>
        /// Returns the Upload object with status `pending`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.Upload>> CreateUploadAsResponseAsync(

            global::tryAGI.OpenAI.CreateUploadRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create upload<br/>
        /// Creates an intermediate [Upload](https://developers.openai.com/api/reference/resources/uploads) object<br/>
        /// that you can add [Parts](https://developers.openai.com/api/reference/resources/uploads/subresources/parts) to.<br/>
        /// Currently, an Upload can accept at most 8 GB in total and expires after an<br/>
        /// hour after you create it.<br/>
        /// Once you complete the Upload, we will create a<br/>
        /// [File](https://developers.openai.com/api/reference/resources/files) object that contains all the parts<br/>
        /// you uploaded. This File is usable in the rest of our platform as a regular<br/>
        /// File object.<br/>
        /// For certain `purpose` values, the correct `mime_type` must be specified.<br/>
        /// Please refer to documentation for the<br/>
        /// [supported MIME types for your use case](https://developers.openai.com/api/docs/guides/tools-file-search#supported-files).<br/>
        /// For guidance on the proper filename extensions for each purpose, please<br/>
        /// follow the documentation on [creating a<br/>
        /// File](https://developers.openai.com/api/reference/resources/files/methods/create).<br/>
        /// Returns the Upload object with status `pending`.
        /// </summary>
        /// <param name="filename">
        /// The name of the file to upload.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.<br/>
        /// See the [documentation on File<br/>
        /// purposes](https://developers.openai.com/api/reference/resources/files/methods/create#%28resource%29%20files%20%3E%20%28method%29%20create%20%3E%20%28params%29%200%20%3E%20%28param%29%20purpose%20%3E%20%28schema%29).
        /// </param>
        /// <param name="bytes">
        /// The number of bytes in the file you are uploading.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file.<br/>
        /// This must fall within the supported MIME types for your file purpose. See<br/>
        /// the supported MIME types for assistants and vision.
        /// </param>
        /// <param name="expiresAfter">
        /// The expiration policy for a file. By default, files with `purpose=batch` expire after 30 days and all other files are persisted until they are manually deleted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Upload> CreateUploadAsync(
            string filename,
            global::tryAGI.OpenAI.CreateUploadRequestPurpose purpose,
            long bytes,
            string mimeType,
            global::tryAGI.OpenAI.FileExpirationAfter? expiresAfter = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}