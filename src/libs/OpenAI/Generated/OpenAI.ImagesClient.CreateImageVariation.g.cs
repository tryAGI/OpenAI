
#nullable enable

namespace OpenAI
{
    public partial class ImagesClient
    {
        /// <summary>
        /// Creates a variation of a given image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.ImagesResponse> CreateImageVariationAsync(
            global::OpenAI.CreateImageVariationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/images/variations", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateImageVariationRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::OpenAI.SourceGenerationContext.Default.ImagesResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a variation of a given image.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="responseFormat"></param>
        /// <param name="size"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.ImagesResponse> CreateImageVariationAsync(
            byte[] image,
            global::System.AnyOf<string?, global::OpenAI.CreateImageVariationRequestModel?>? model = default,
            int? n = 1,
            global::OpenAI.CreateImageVariationRequestResponseFormat? responseFormat = global::OpenAI.CreateImageVariationRequestResponseFormat.Url,
            global::OpenAI.CreateImageVariationRequestSize? size = global::OpenAI.CreateImageVariationRequestSize._1024x1024,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateImageVariationRequest
            {
                Image = image,
                Model = model,
                N = n,
                ResponseFormat = responseFormat,
                Size = size,
                User = user,
            };

            return await CreateImageVariationAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}