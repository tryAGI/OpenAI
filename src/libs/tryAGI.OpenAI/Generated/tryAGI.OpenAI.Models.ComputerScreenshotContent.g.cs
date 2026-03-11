
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A screenshot of a computer.
    /// </summary>
    public sealed partial class ComputerScreenshotContent
    {
        /// <summary>
        /// Specifies the event type. For a computer screenshot, this property is always set to `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerScreenshotContentType.ComputerScreenshot</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerScreenshotContentType Type { get; set; } = global::tryAGI.OpenAI.ComputerScreenshotContentType.ComputerScreenshot;

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ImageDetail Detail { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScreenshotContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a computer screenshot, this property is always set to `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="fileId"></param>
        /// <param name="detail">
        /// The detail level of the screenshot image to be sent to the model. One of `high`, `low`, `auto`, or `original`. Defaults to `auto`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerScreenshotContent(
            global::tryAGI.OpenAI.ImageDetail detail,
            string? imageUrl,
            string? fileId,
            global::tryAGI.OpenAI.ComputerScreenshotContentType type = global::tryAGI.OpenAI.ComputerScreenshotContentType.ComputerScreenshot)
        {
            this.Detail = detail;
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScreenshotContent" /> class.
        /// </summary>
        public ComputerScreenshotContent()
        {
        }
    }
}