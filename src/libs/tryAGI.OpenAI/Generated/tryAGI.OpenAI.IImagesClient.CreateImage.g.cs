#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Create image<br/>
        /// Creates an image given a prompt. [Learn more](https://developers.openai.com/api/docs/guides/images-vision).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ImagesResponse> CreateImageAsync(

            global::tryAGI.OpenAI.CreateImageRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image<br/>
        /// Creates an image given a prompt. [Learn more](https://developers.openai.com/api/docs/guides/images-vision).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.ImagesResponse>> CreateImageAsResponseAsync(

            global::tryAGI.OpenAI.CreateImageRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image<br/>
        /// Creates an image given a prompt. [Learn more](https://developers.openai.com/api/docs/guides/images-vision).
        /// </summary>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 32000 characters for the GPT image models, 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.<br/>
        /// Example: A cute baby sea otter
        /// </param>
        /// <param name="model">
        /// The model to use for image generation. One of `dall-e-2`, `dall-e-3`, or a GPT image model (`gpt-image-1`, `gpt-image-1-mini`, `gpt-image-1.5`, `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, `gpt-image-2.5-flare-2026-09-08`). Defaults to `dall-e-2` unless a parameter specific to the GPT image models is used.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: gpt-image-2.5-flare
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated.<br/>
        /// - `auto` (default value) will automatically select the best quality for the given<br/>
        ///   model.<br/>
        /// - `high`, `medium` and `low` are supported for the GPT image models.<br/>
        /// - `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08`<br/>
        ///   snapshots, also support `xhigh` and `max`.<br/>
        /// - `hd` and `standard` are supported for `dall-e-3`.<br/>
        /// - `standard` is the only option for `dall-e-2`.<br/>
        /// Default Value: auto<br/>
        /// Example: medium
        /// </param>
        /// <param name="responseFormat">
        /// The format in which generated images with `dall-e-2` and `dall-e-3` are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter isn't supported for the GPT image models, which always return base64-encoded images.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </param>
        /// <param name="outputFormat">
        /// The format in which the generated images are returned. This parameter is only supported for the GPT image models. Must be one of `png`, `jpeg`, or `webp`.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </param>
        /// <param name="outputCompression">
        /// The compression level (0-100%) for the generated images. This parameter is only supported for the GPT image models with the `webp` or `jpeg` output formats, and defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="partialImages"></param>
        /// <param name="size">
        /// The size of the generated images. For `gpt-image-2`, `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`, `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`, and `gpt-image-2.5-flare-2026-09-08`, arbitrary resolutions are supported as `WIDTHxHEIGHT` strings, for example `1536x864`. Width and height must both be divisible by 16 and the requested aspect ratio must be between 1:3 and 3:1. Resolutions above `2560x1440` are experimental, and the maximum supported resolution is `3840x2160`. The requested size must also satisfy the model's current pixel and edge limits. The standard sizes `1024x1024`, `1536x1024`, and `1024x1536` are supported by the GPT image models; `auto` is supported for models that allow automatic sizing. For `dall-e-2`, use one of `256x256`, `512x512`, or `1024x1024`. For `dall-e-3`, use one of `1024x1024`, `1792x1024`, or `1024x1792`.<br/>
        /// Default Value: auto<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="moderation">
        /// Control the content-moderation level for images generated by the GPT image models. Must be either `low` for less restrictive filtering or `auto` (default value).<br/>
        /// Default Value: auto<br/>
        /// Example: low
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
        /// <param name="style">
        /// The style of the generated images. This parameter is only supported for `dall-e-3`. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images.<br/>
        /// Default Value: vivid<br/>
        /// Example: vivid
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](https://developers.openai.com/api/docs/guides/safety-best-practices#implement-safety-identifiers).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ImagesResponse> CreateImageAsync(
            string prompt,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>? model = default,
            int? n = default,
            global::tryAGI.OpenAI.CreateImageRequestQuality? quality = default,
            global::tryAGI.OpenAI.CreateImageRequestResponseFormat? responseFormat = default,
            global::tryAGI.OpenAI.CreateImageRequestOutputFormat? outputFormat = default,
            int? outputCompression = default,
            int? partialImages = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestSize?>? size = default,
            global::tryAGI.OpenAI.CreateImageRequestModeration? moderation = default,
            global::tryAGI.OpenAI.CreateImageRequestBackground? background = default,
            global::tryAGI.OpenAI.CreateImageRequestStyle? style = default,
            string? user = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}