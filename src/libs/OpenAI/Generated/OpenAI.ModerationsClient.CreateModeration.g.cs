
#nullable enable

namespace OpenAI
{
    public partial class ModerationsClient
    {
        partial void PrepareCreateModerationArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::OpenAI.CreateModerationRequest request);
        partial void PrepareCreateModerationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::OpenAI.CreateModerationRequest request);
        partial void ProcessCreateModerationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateModerationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Classifies if text and/or image inputs are potentially harmful. Learn<br/>
        /// more in the [moderation guide](/docs/guides/moderation).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.CreateModerationResponse> CreateModerationAsync(
            global::OpenAI.CreateModerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateModerationArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/moderations",
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
            PrepareCreateModerationRequest(
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
            ProcessCreateModerationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateModerationResponseContent(
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
                global::OpenAI.CreateModerationResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Classifies if text and/or image inputs are potentially harmful. Learn<br/>
        /// more in the [moderation guide](/docs/guides/moderation).
        /// </summary>
        /// <param name="input">
        /// Input (or inputs) to classify. Can be a single string, an array of strings, or<br/>
        /// an array of multi-modal input objects similar to other models.
        /// </param>
        /// <param name="model">
        /// The content moderation model you would like to use. Learn more in<br/>
        /// [the moderation guide](/docs/guides/moderation), and learn about<br/>
        /// available models [here](/docs/models/moderation).<br/>
        /// Default Value: omni-moderation-latest<br/>
        /// Example: omni-moderation-2024-09-26
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.CreateModerationResponse> CreateModerationAsync(
            global::OpenAI.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::OpenAI.InputVariant3Item>> input,
            global::OpenAI.AnyOf<string, global::OpenAI.CreateModerationRequestModel?>? model = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateModerationRequest
            {
                Input = input,
                Model = model,
            };

            return await CreateModerationAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}