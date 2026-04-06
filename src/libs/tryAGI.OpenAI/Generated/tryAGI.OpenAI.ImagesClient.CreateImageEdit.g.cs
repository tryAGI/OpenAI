
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class ImagesClient
    {
        partial void PrepareCreateImageEditArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::tryAGI.OpenAI.CreateImageEditRequest request);
        partial void PrepareCreateImageEditRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::tryAGI.OpenAI.CreateImageEditRequest request);
        partial void ProcessCreateImageEditResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateImageEditResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models (`gpt-image-1.5`, `gpt-image-1`, `gpt-image-1-mini`, and `chatgpt-image-latest`) and `dall-e-2`.<br/>
        /// You can call this endpoint with either:<br/>
        /// - `multipart/form-data`: use binary uploads via `image` (and optional `mask`).<br/>
        /// - `application/json`: use `images` (and optional `mask`) as references with either `image_url` or `file_id`.<br/>
        /// Note that JSON requests use `images` (array) instead of the multipart `image` field.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ImagesResponse> CreateImageEditAsync(

            global::tryAGI.OpenAI.CreateImageEditRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::tryAGI.OpenAI.CreateImageEditRequest
            {
                Image = request.Image,
                Prompt = request.Prompt,
                Mask = request.Mask,
                Maskname = request.Maskname,
                Background = request.Background,
                Model = request.Model,
                N = request.N,
                Size = request.Size,
                ResponseFormat = request.ResponseFormat,
                OutputFormat = request.OutputFormat,
                OutputCompression = request.OutputCompression,
                User = request.User,
                InputFidelity = request.InputFidelity,
                Stream = false,
                PartialImages = request.PartialImages,
                Quality = request.Quality,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateImageEditArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::tryAGI.OpenAI.PathBuilder(
                path: "/images/edits",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent(request.Image.ToString() ?? string.Empty),
                name: "\"image\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                name: "\"prompt\"");
            if (request.Mask != default)
            {

                var __contentMask = new global::System.Net.Http.ByteArrayContent(request.Mask ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentMask,
                    name: "\"mask\"",
                    fileName: request.Maskname != null ? $"\"{request.Maskname}\"" : string.Empty);
                if (__contentMask.Headers.ContentDisposition != null)
                {
                    __contentMask.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.Background != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Background?.ToValueString()}"),
                    name: "\"background\"");
            } 
            if (request.Model != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.Model?.ToString() ?? string.Empty),
                    name: "\"model\"");
            } 
            if (request.N != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.N}"),
                    name: "\"n\"");
            } 
            if (request.Size != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Size?.ToValueString()}"),
                    name: "\"size\"");
            } 
            if (request.ResponseFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ResponseFormat?.ToValueString()}"),
                    name: "\"response_format\"");
            } 
            if (request.OutputFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputFormat?.ToValueString()}"),
                    name: "\"output_format\"");
            } 
            if (request.OutputCompression != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputCompression}"),
                    name: "\"output_compression\"");
            } 
            if (request.User != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.User}"),
                    name: "\"user\"");
            } 
            if (request.InputFidelity != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InputFidelity}"),
                    name: "\"input_fidelity\"");
            } 
            if (request.Stream != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Stream}"),
                    name: "\"stream\"");
            } 
            if (request.PartialImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PartialImages}"),
                    name: "\"partial_images\"");
            } 
            if (request.Quality != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Quality?.ToValueString()}"),
                    name: "\"quality\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateImageEditRequest(
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
            ProcessCreateImageEditResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateImageEditResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::tryAGI.OpenAI.ImagesResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::tryAGI.OpenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::tryAGI.OpenAI.ImagesResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::tryAGI.OpenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models (`gpt-image-1.5`, `gpt-image-1`, `gpt-image-1-mini`, and `chatgpt-image-latest`) and `dall-e-2`.<br/>
        /// You can call this endpoint with either:<br/>
        /// - `multipart/form-data`: use binary uploads via `image` (and optional `mask`).<br/>
        /// - `application/json`: use `images` (and optional `mask`) as references with either `image_url` or `file_id`.<br/>
        /// Note that JSON requests use `images` (array) instead of the multipart `image` field.
        /// </summary>
        /// <param name="image">
        /// The image(s) to edit. Must be a supported image file or an array of images.<br/>
        /// For the GPT image models (`gpt-image-1`, `gpt-image-1-mini`, and `gpt-image-1.5`), each image should be a `png`, `webp`, or `jpg`<br/>
        /// file less than 50MB. You can provide up to 16 images.<br/>
        /// `chatgpt-image-latest` follows the same input constraints as GPT image models.<br/>
        /// For `dall-e-2`, you can only provide one image, and it should be a square<br/>
        /// `png` file less than 4MB.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2`, and 32000 characters for the GPT image models.<br/>
        /// Example: A cute baby sea otter wearing a beret
        /// </param>
        /// <param name="mask">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
        /// </param>
        /// <param name="maskname">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
        /// </param>
        /// <param name="background">
        /// Allows to set transparency for the background of the generated image(s).<br/>
        /// This parameter is only supported for the GPT image models. Must be one of<br/>
        /// `transparent`, `opaque` or `auto` (default value). When `auto` is used, the<br/>
        /// model will automatically determine the best background for the image.<br/>
        /// If `transparent`, the output format needs to support transparency, so it<br/>
        /// should be set to either `png` (default value) or `webp`.<br/>
        /// Default Value: auto<br/>
        /// Example: transparent
        /// </param>
        /// <param name="model">
        /// The model to use for image generation. Defaults to `gpt-image-1.5`.<br/>
        /// Default Value: gpt-image-1.5<br/>
        /// Example: gpt-image-1.5
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `1024x1024`, `1536x1024` (landscape), `1024x1536` (portrait), or `auto` (default value) for the GPT image models, and one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="responseFormat">
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter is only supported for `dall-e-2` (default is `url` for `dall-e-2`), as GPT image models always return base64-encoded images.<br/>
        /// Example: url
        /// </param>
        /// <param name="outputFormat">
        /// The format in which the generated images are returned. This parameter is<br/>
        /// only supported for the GPT image models. Must be one of `png`, `jpeg`, or `webp`.<br/>
        /// The default value is `png`.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </param>
        /// <param name="outputCompression">
        /// The compression level (0-100%) for the generated images. This parameter<br/>
        /// is only supported for the GPT image models with the `webp` or `jpeg` output<br/>
        /// formats, and defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="inputFidelity"></param>
        /// <param name="partialImages"></param>
        /// <param name="quality">
        /// The quality of the image that will be generated for GPT image models. Defaults to `auto`.<br/>
        /// Default Value: auto<br/>
        /// Example: high
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ImagesResponse> CreateImageEditAsync(
            global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>> image,
            string prompt,
            byte[]? mask = default,
            string? maskname = default,
            global::tryAGI.OpenAI.CreateImageEditRequestBackground? background = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>? model = default,
            int? n = default,
            global::tryAGI.OpenAI.CreateImageEditRequestSize? size = default,
            global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat? responseFormat = default,
            global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat? outputFormat = default,
            int? outputCompression = default,
            string? user = default,
            global::tryAGI.OpenAI.InputFidelity? inputFidelity = default,
            int? partialImages = default,
            global::tryAGI.OpenAI.CreateImageEditRequestQuality? quality = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.CreateImageEditRequest
            {
                Image = image,
                Prompt = prompt,
                Mask = mask,
                Maskname = maskname,
                Background = background,
                Model = model,
                N = n,
                Size = size,
                ResponseFormat = responseFormat,
                OutputFormat = outputFormat,
                OutputCompression = outputCompression,
                User = user,
                InputFidelity = inputFidelity,
                Stream = false,
                PartialImages = partialImages,
                Quality = quality,
            };

            return await CreateImageEditAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}