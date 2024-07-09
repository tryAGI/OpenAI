
#nullable enable

namespace OpenAI
{
    public partial class AudioClient
    {
        partial void PrepareCreateTranscriptionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::OpenAI.CreateTranscriptionRequest request);
        partial void PrepareCreateTranscriptionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::OpenAI.CreateTranscriptionRequest request);
        partial void ProcessCreateTranscriptionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTranscriptionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.OneOf<global::OpenAI.CreateTranscriptionResponseJson, global::OpenAI.CreateTranscriptionResponseVerboseJson>> CreateTranscriptionAsync(
            global::OpenAI.CreateTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateTranscriptionArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/audio/transcriptions", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateTranscriptionRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateTranscriptionRequest(
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
            ProcessCreateTranscriptionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateTranscriptionResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::OpenAI.SourceGenerationContext.Default.NullableOneOfCreateTranscriptionResponseJsonCreateTranscriptionResponseVerboseJson) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Transcribes audio into the input language.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <param name="language"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat"></param>
        /// <param name="temperature"></param>
        /// <param name="timestampGranularities"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.OneOf<global::OpenAI.CreateTranscriptionResponseJson, global::OpenAI.CreateTranscriptionResponseVerboseJson>> CreateTranscriptionAsync(
            byte[] file,
            global::System.AnyOf<string, global::OpenAI.CreateTranscriptionRequestModel> model,
            string? language = default,
            string? prompt = default,
            global::OpenAI.CreateTranscriptionRequestResponseFormat? responseFormat = global::OpenAI.CreateTranscriptionRequestResponseFormat.Json,
            double temperature = 0,
            global::System.Collections.Generic.IList<global::OpenAI.CreateTranscriptionRequestTimestampGranularities?>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateTranscriptionRequest
            {
                File = file,
                Model = model,
                Language = language,
                Prompt = prompt,
                ResponseFormat = responseFormat,
                Temperature = temperature,
                TimestampGranularities = timestampGranularities,
            };

            return await CreateTranscriptionAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}