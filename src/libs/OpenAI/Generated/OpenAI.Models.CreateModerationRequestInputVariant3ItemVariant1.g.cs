
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// An object describing an image to classify.
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemVariant1
    {
        /// <summary>
        /// Always `image_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant1TypeJsonConverter))]
        public global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type Type { get; set; }

        /// <summary>
        /// Contains either an image URL or a data URL for a base64 encoded image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}