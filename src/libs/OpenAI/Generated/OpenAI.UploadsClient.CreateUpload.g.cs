
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
        /// Creates an intermediate [Upload](/docs/api-reference/uploads/object) object that you can add [Parts](/docs/api-reference/uploads/part-object) to. Currently, an Upload can accept at most 8 GB in total and expires after an hour after you create it.<br/>
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
                client: HttpClient);
            PrepareCreateUploadArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/uploads",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateUploadRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateUploadResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateUploadResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::OpenAI.Upload.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates an intermediate [Upload](/docs/api-reference/uploads/object) object that you can add [Parts](/docs/api-reference/uploads/part-object) to. Currently, an Upload can accept at most 8 GB in total and expires after an hour after you create it.<br/>
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
            string filename,
            global::OpenAI.CreateUploadRequestPurpose purpose,
            int bytes,
            string mimeType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::OpenAI.CreateUploadRequest
            {
                Filename = filename,
                Purpose = purpose,
                Bytes = bytes,
                MimeType = mimeType,
            };

            return await CreateUploadAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}