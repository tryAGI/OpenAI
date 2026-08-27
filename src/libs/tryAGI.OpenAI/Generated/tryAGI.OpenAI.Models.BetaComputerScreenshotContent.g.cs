
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A screenshot of a computer.
    /// </summary>
    public sealed partial class BetaComputerScreenshotContent
    {
        /// <summary>
        /// Specifies the event type. For a computer screenshot, this property is always set to `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaComputerScreenshotContentType.ComputerScreenshot</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaComputerScreenshotContentType Type { get; set; } = global::tryAGI.OpenAI.BetaComputerScreenshotContentType.ComputerScreenshot;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The detail level of the screenshot image to be sent to the model. One of `high`, `low`, `auto`, or `original`. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaImageDetail Detail { get; set; }

        /// <summary>
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerScreenshotContent" /> class.
        /// </summary>
        /// <param name="detail">
        /// The detail level of the screenshot image to be sent to the model. One of `high`, `low`, `auto`, or `original`. Defaults to `auto`.
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="fileId"></param>
        /// <param name="promptCacheBreakpoint">
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a computer screenshot, this property is always set to `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComputerScreenshotContent(
            global::tryAGI.OpenAI.BetaImageDetail detail,
            string? imageUrl,
            string? fileId,
            global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? promptCacheBreakpoint,
            global::tryAGI.OpenAI.BetaComputerScreenshotContentType type = global::tryAGI.OpenAI.BetaComputerScreenshotContentType.ComputerScreenshot)
        {
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
            this.Detail = detail;
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerScreenshotContent" /> class.
        /// </summary>
        public BetaComputerScreenshotContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaComputerScreenshotContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaComputerScreenshotContent FromDetail(global::tryAGI.OpenAI.BetaImageDetail detail)
        {
            return new BetaComputerScreenshotContent
            {
                Detail = detail,
            };
        }

    }
}