
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Contains either an image URL or a data URL for a base64 encoded image.
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemVariant1ImageUrl
    {
        /// <summary>
        /// Either a URL of the image or the base64 encoded image data.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}