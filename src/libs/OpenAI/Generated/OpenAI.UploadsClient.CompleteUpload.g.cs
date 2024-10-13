
#nullable enable

namespace OpenAI
{
    public partial class UploadsClient
    {
        partial void PrepareCompleteUploadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string uploadId,
            global::OpenAI.CompleteUploadRequest request);
        partial void PrepareCompleteUploadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string uploadId,
            global::OpenAI.CompleteUploadRequest request);
        partial void ProcessCompleteUploadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCompleteUploadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Completes the [Upload](/docs/api-reference/uploads/object). <br/>
        /// Within the returned Upload object, there is a nested [File](/docs/api-reference/files/object) object that is ready to use in the rest of the platform.<br/>
        /// You can specify the order of the Parts by passing in an ordered list of the Part IDs.<br/>
        /// The number of bytes uploaded upon completion must match the number of bytes initially specified when creating the Upload object. No Parts may be added after an Upload is completed.
        /// </summary>
        /// <param name="uploadId">
        /// Example: upload_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.Upload> CompleteUploadAsync(
            string uploadId,
            global::OpenAI.CompleteUploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCompleteUploadArguments(
                httpClient: _httpClient,
                uploadId: ref uploadId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/uploads/{uploadId}/complete",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCompleteUploadRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                uploadId: uploadId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCompleteUploadResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCompleteUploadResponseContent(
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
                global::OpenAI.Upload.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Completes the [Upload](/docs/api-reference/uploads/object). <br/>
        /// Within the returned Upload object, there is a nested [File](/docs/api-reference/files/object) object that is ready to use in the rest of the platform.<br/>
        /// You can specify the order of the Parts by passing in an ordered list of the Part IDs.<br/>
        /// The number of bytes uploaded upon completion must match the number of bytes initially specified when creating the Upload object. No Parts may be added after an Upload is completed.
        /// </summary>
        /// <param name="uploadId">
        /// Example: upload_abc123
        /// </param>
        /// <param name="partIds">
        /// The ordered list of Part IDs.
        /// </param>
        /// <param name="md5">
        /// The optional md5 checksum for the file contents to verify if the bytes uploaded matches what you expect.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.Upload> CompleteUploadAsync(
            string uploadId,
            global::System.Collections.Generic.IList<string> partIds,
            string? md5 = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CompleteUploadRequest
            {
                PartIds = partIds,
                Md5 = md5,
            };

            return await CompleteUploadAsync(
                uploadId: uploadId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}