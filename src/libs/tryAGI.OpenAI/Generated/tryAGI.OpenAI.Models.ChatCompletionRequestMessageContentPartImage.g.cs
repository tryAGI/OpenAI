
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Learn about [image inputs](https://developers.openai.com/api/docs/guides/images-vision).
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartImage
    {
        /// <summary>
        /// The type of the content part.
        /// </summary>
        /// <default>"image_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image_url";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Marks the exact end of a reusable prompt prefix. When `ttl` is omitted, the breakpoint inherits the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::tryAGI.OpenAI.PromptCacheBreakpointParam? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="promptCacheBreakpoint">
        /// Marks the exact end of a reusable prompt prefix. When `ttl` is omitted, the breakpoint inherits the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </param>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestMessageContentPartImage(
            global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl imageUrl,
            global::tryAGI.OpenAI.PromptCacheBreakpointParam? promptCacheBreakpoint,
            string type = "image_url")
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionRequestMessageContentPartImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartImage FromImageUrl(global::tryAGI.OpenAI.ChatCompletionRequestMessageContentPartImageImageUrl imageUrl)
        {
            return new ChatCompletionRequestMessageContentPartImage
            {
                ImageUrl = imageUrl,
            };
        }

    }
}