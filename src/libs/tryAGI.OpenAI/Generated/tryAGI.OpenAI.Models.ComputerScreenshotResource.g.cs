
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A browser screenshot emitted by the model during computer use.
    /// </summary>
    public sealed partial class ComputerScreenshotResource
    {
        /// <summary>
        /// The content type. Always `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ComputerScreenshotResourceType.ComputerScreenshot</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.ComputerScreenshotResourceType Type { get; set; } = global::tryAGI.OpenAI.ComputerScreenshotResourceType.ComputerScreenshot;

        /// <summary>
        /// The complete JPEG image as a base64 data URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScreenshotResource" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The complete JPEG image as a base64 data URL.
        /// </param>
        /// <param name="type">
        /// The content type. Always `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerScreenshotResource(
            string imageUrl,
            global::tryAGI.OpenAI.ComputerScreenshotResourceType type = global::tryAGI.OpenAI.ComputerScreenshotResourceType.ComputerScreenshot)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScreenshotResource" /> class.
        /// </summary>
        public ComputerScreenshotResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ComputerScreenshotResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ComputerScreenshotResource FromImageUrl(string imageUrl)
        {
            return new ComputerScreenshotResource
            {
                ImageUrl = imageUrl,
            };
        }

    }
}