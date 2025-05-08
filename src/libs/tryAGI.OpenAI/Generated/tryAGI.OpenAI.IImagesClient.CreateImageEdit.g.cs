#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Creates an edited or extended image given one or more source images and a prompt. This endpoint only supports `gpt-image-1` and `dall-e-2`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ImagesResponse> CreateImageEditAsync(
            global::tryAGI.OpenAI.CreateImageEditRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an edited or extended image given one or more source images and a prompt. This endpoint only supports `gpt-image-1` and `dall-e-2`.
        /// </summary>
        /// <param name="image">
        /// The image(s) to edit. Must be a supported image file or an array of images.<br/>
        /// For `gpt-image-1`, each image should be a `png`, `webp`, or `jpg` file less <br/>
        /// than 25MB. You can provide up to 16 images.<br/>
        /// For `dall-e-2`, you can only provide one image, and it should be a square <br/>
        /// `png` file less than 4MB.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2`, and 32000 characters for `gpt-image-1`.<br/>
        /// Example: A cute baby sea otter wearing a beret
        /// </param>
        /// <param name="mask">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
        /// </param>
        /// <param name="maskname">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
        /// </param>
        /// <param name="model">
        /// The model to use for image generation. Only `dall-e-2` and `gpt-image-1` are supported. Defaults to `dall-e-2` unless a parameter specific to `gpt-image-1` is used.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: gpt-image-1
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `1024x1024`, `1536x1024` (landscape), `1024x1536` (portrait), or `auto` (default value) for `gpt-image-1`, and one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="responseFormat">
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter is only supported for `dall-e-2`, as `gpt-image-1` will always return base64-encoded images.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated. `high`, `medium` and `low` are only supported for `gpt-image-1`. `dall-e-2` only supports `standard` quality. Defaults to `auto`.<br/>
        /// Default Value: auto<br/>
        /// Example: high
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ImagesResponse> CreateImageEditAsync(
            global::tryAGI.OpenAI.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>> image,
            string prompt,
            byte[]? mask = default,
            string? maskname = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageEditRequestModel?>? model = default,
            int? n = default,
            global::tryAGI.OpenAI.CreateImageEditRequestSize? size = default,
            global::tryAGI.OpenAI.CreateImageEditRequestResponseFormat? responseFormat = default,
            string? user = default,
            global::tryAGI.OpenAI.CreateImageEditRequestQuality? quality = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}