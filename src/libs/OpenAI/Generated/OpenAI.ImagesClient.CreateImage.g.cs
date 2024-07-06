
#nullable enable

namespace OpenAI
{
    public partial class ImagesClient
    {
        /// <summary>
        /// Creates an image given a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.ImagesResponse> CreateImageAsync(
            global::OpenAI.CreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/images/generations", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateImageRequest);
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
        /// Creates an image given a prompt.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="quality"></param>
        /// <param name="responseFormat"></param>
        /// <param name="size"></param>
        /// <param name="style"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.ImagesResponse> CreateImageAsync(
            string prompt,
            global::System.AnyOf<string?, global::OpenAI.CreateImageRequestModel?>? model = default,
            int? n = 1,
            global::OpenAI.CreateImageRequestQuality? quality = global::OpenAI.CreateImageRequestQuality.Standard,
            global::OpenAI.CreateImageRequestResponseFormat? responseFormat = global::OpenAI.CreateImageRequestResponseFormat.Url,
            global::OpenAI.CreateImageRequestSize? size = global::OpenAI.CreateImageRequestSize._1024x1024,
            global::OpenAI.CreateImageRequestStyle? style = global::OpenAI.CreateImageRequestStyle.Vivid,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateImageRequest
            {
                Prompt = prompt,
                Model = model,
                N = n,
                Quality = quality,
                ResponseFormat = responseFormat,
                Size = size,
                Style = style,
                User = user,
            };

            return await CreateImageAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}