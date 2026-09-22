#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Create image edit<br/>
        /// Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models and `dall-e-2`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ImagesResponse> CreateImageEditAsync(

            global::tryAGI.OpenAI.CreateImageEditRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image edit<br/>
        /// Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models and `dall-e-2`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ImagesResponse>> CreateImageEditAsResponseAsync(

            global::tryAGI.OpenAI.CreateImageEditRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image edit<br/>
        /// Creates an edited or extended image given one or more source images and a prompt. This endpoint supports GPT Image models and `dall-e-2`.
        /// </summary>
        /// <param name="image">
        /// The image(s) to edit. Must be a supported image file or an array of images.<br/>
        /// For the GPT image models (`gpt-image-1`, `gpt-image-1-mini`, `gpt-image-1.5`,<br/>
        /// `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`,<br/>
        /// `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and<br/>
        /// `gpt-image-2.5-flare-2026-09-08`), each image should be a `png`, `webp`, or `jpg`<br/>
        /// file less than 50MB. You can provide up to 16 images. `chatgpt-image-latest`<br/>
        /// follows the same input constraints as GPT image models.<br/>
        /// For `dall-e-2`, you can only provide one image, and it should be a square `png`<br/>
        /// file less than 4MB.
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
        /// Set the background of the generated image(s). This parameter is only supported for<br/>
        /// the GPT image models. Must be one of `transparent`, `opaque`, or `auto` (default<br/>
        /// value). When `auto` is used, the model will automatically determine the best<br/>
        /// background for the image.<br/>
        /// `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08`<br/>
        /// snapshots, support `opaque` and `transparent` backgrounds. Transparent backgrounds<br/>
        /// are available for supported GPT Image models. For `gpt-image-2` and<br/>
        /// `gpt-image-2-2026-04-21`, this support is in preview. When using `transparent`,<br/>
        /// set the output format to `png` or `webp`.<br/>
        /// Default Value: auto<br/>
        /// Example: transparent
        /// </param>
        /// <param name="model">
        /// The model to use for image generation. One of `dall-e-2` or a GPT image model (`gpt-image-1`, `gpt-image-1-mini`, `gpt-image-1.5`, `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, `gpt-image-2.5-flare-2026-09-08`, or `chatgpt-image-latest`). Defaults to `gpt-image-1.5`.<br/>
        /// Default Value: gpt-image-1.5<br/>
        /// Example: gpt-image-1.5
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="size">
        /// The size of the generated images. For `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing. For `dall-e-2`, use one of `256x256`, `512x512`, or `1024x1024`. For `dall-e-3`, use one of `1024x1024`, `1792x1024`, or `1024x1792`.<br/>
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
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](https://developers.openai.com/api/docs/guides/safety-best-practices#implement-safety-identifiers).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="inputFidelity"></param>
        /// <param name="partialImages"></param>
        /// <param name="quality">
        /// The quality of the image that will be generated for GPT image models. The GPT image models support `low`, `medium`, and `high`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08` snapshots, also support `xhigh` and `max`. Defaults to `auto`.<br/>
        /// Default Value: auto<br/>
        /// Example: high
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ImagesResponse> CreateImageEditAsync(
            global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>> image,
            string prompt,
            byte[]? mask = default,
            string? maskname = default,
            global::tryAGI.OpenAI.CreateImageEditRequestBackground? background = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>? model = default,
            int? n = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestSize?>? size = default,
            global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat? responseFormat = default,
            global::tryAGI.OpenAI.CreateImageEditRequestOutputFormat? outputFormat = default,
            int? outputCompression = default,
            string? user = default,
            global::tryAGI.OpenAI.InputFidelity? inputFidelity = default,
            int? partialImages = default,
            global::tryAGI.OpenAI.CreateImageEditRequestQuality? quality = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}