
#nullable enable

namespace tryAGI.OpenAI
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateModerationRequestInputVariant3ItemVariant1TypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type Type { get; set; }

        /// <summary>
        /// Contains either an image URL or a data URL for a base64 encoded image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `image_url`.
        /// </param>
        /// <param name="imageUrl">
        /// Contains either an image URL or a data URL for a base64 encoded image.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateModerationRequestInputVariant3ItemVariant1(
            global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl imageUrl,
            global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1Type type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant1" /> class.
        /// </summary>
        public CreateModerationRequestInputVariant3ItemVariant1()
        {
        }
    }
}