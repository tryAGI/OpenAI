
#nullable enable

namespace OpenAI
{
    public partial class AudioClient
    {
        partial void PrepareCreateSpeechArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::OpenAI.CreateSpeechRequest request);
        partial void PrepareCreateSpeechRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::OpenAI.CreateSpeechRequest request);
        partial void ProcessCreateSpeechResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSpeechResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            global::OpenAI.CreateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateSpeechArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/audio/speech", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateSpeechRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateSpeechRequest(
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
            ProcessCreateSpeechResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateSpeechResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::OpenAI.SourceGenerationContext.Default.ByteArray) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="voice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="speed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            global::System.AnyOf<string, global::OpenAI.CreateSpeechRequestModel> model,
            string input,
            global::OpenAI.CreateSpeechRequestVoice voice,
            global::OpenAI.CreateSpeechRequestResponseFormat? responseFormat = global::OpenAI.CreateSpeechRequestResponseFormat.Mp3,
            double speed = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateSpeechRequest
            {
                Model = model,
                Input = input,
                Voice = voice,
                ResponseFormat = responseFormat,
                Speed = speed,
            };

            return await CreateSpeechAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}