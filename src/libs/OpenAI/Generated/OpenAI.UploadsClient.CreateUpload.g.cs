
#nullable enable

namespace OpenAI
{
    public partial class UploadsClient
    {
        partial void PrepareCreateUploadArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::OpenAI.CreateUploadRequest request);
        partial void PrepareCreateUploadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::OpenAI.CreateUploadRequest request);
        partial void ProcessCreateUploadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateUploadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates an intermediate [Upload](/docs/api-reference/uploads/object) object that you can add [Parts](/docs/api-reference/uploads/part-object) to. Currently, an Upload can accept at most 10 GB in total and expires after an hour after you create it.<br/>
        /// Once you complete the Upload, we will create a [File](/docs/api-reference/files/object) object that contains all the parts you uploaded. This File is usable in the rest of our platform as a regular File object.<br/>
        /// For certain `purpose`s, the correct `mime_type` must be specified. Please refer to documentation for the supported MIME types for your use case:<br/>
        /// - [Assistants](/docs/assistants/tools/file-search/supported-files)<br/>
        /// For guidance on the proper filename extensions for each purpose, please follow the documentation on [creating a File](/docs/api-reference/files/create).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.Upload> CreateUploadAsync(
            global::OpenAI.CreateUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateUploadArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/uploads", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateUploadRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateUploadRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateUploadResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateUploadResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::OpenAI.SourceGenerationContext.Default.Upload) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates an intermediate [Upload](/docs/api-reference/uploads/object) object that you can add [Parts](/docs/api-reference/uploads/part-object) to. Currently, an Upload can accept at most 10 GB in total and expires after an hour after you create it.<br/>
        /// Once you complete the Upload, we will create a [File](/docs/api-reference/files/object) object that contains all the parts you uploaded. This File is usable in the rest of our platform as a regular File object.<br/>
        /// For certain `purpose`s, the correct `mime_type` must be specified. Please refer to documentation for the supported MIME types for your use case:<br/>
        /// - [Assistants](/docs/assistants/tools/file-search/supported-files)<br/>
        /// For guidance on the proper filename extensions for each purpose, please follow the documentation on [creating a File](/docs/api-reference/files/create).
        /// </summary>
        /// <param name="filename">
        /// The name of the file to upload.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file.<br/>
        /// See the [documentation on File purposes](/docs/api-reference/files/create#files-create-purpose).
        /// </param>
        /// <param name="bytes">
        /// The number of bytes in the file you are uploading.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file.<br/>
        /// This must fall within the supported MIME types for your file purpose. See the supported MIME types for assistants and vision.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.Upload> CreateUploadAsync(
            byte[] filename,
            global::OpenAI.CreateUploadRequestPurpose purpose,
            int bytes,
            string mimeType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateUploadRequest
            {
                Filename = filename,
                Purpose = purpose,
                Bytes = bytes,
                MimeType = mimeType,
            };

            return await CreateUploadAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}