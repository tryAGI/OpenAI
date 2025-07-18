
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A computer screenshot image used with the computer use tool.
    /// </summary>
    public sealed partial class ComputerScreenshotImage
    {
        /// <summary>
        /// The identifier of an uploaded file that contains the screenshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The URL of the screenshot image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Specifies the event type. For a computer screenshot, this property is <br/>
        /// always set to `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerScreenshotImageType.ComputerScreenshot</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerScreenshotImageType Type { get; set; } = global::tryAGI.OpenAI.ComputerScreenshotImageType.ComputerScreenshot;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScreenshotImage" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The identifier of an uploaded file that contains the screenshot.
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the screenshot image.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a computer screenshot, this property is <br/>
        /// always set to `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerScreenshotImage(
            string? fileId,
            string? imageUrl,
            global::tryAGI.OpenAI.ComputerScreenshotImageType type = global::tryAGI.OpenAI.ComputerScreenshotImageType.ComputerScreenshot)
        {
            this.FileId = fileId;
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScreenshotImage" /> class.
        /// </summary>
        public ComputerScreenshotImage()
        {
        }
    }
}