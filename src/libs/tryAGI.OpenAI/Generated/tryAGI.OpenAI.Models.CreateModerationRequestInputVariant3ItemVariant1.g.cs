
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
        /// <default>"image_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image_url";

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
        /// <param name="imageUrl">
        /// Contains either an image URL or a data URL for a base64 encoded image.
        /// </param>
        /// <param name="type">
        /// Always `image_url`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModerationRequestInputVariant3ItemVariant1(
            global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl imageUrl,
            string type = "image_url")
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant1" /> class.
        /// </summary>
        public CreateModerationRequestInputVariant3ItemVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateModerationRequestInputVariant3ItemVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateModerationRequestInputVariant3ItemVariant1 FromImageUrl(global::tryAGI.OpenAI.CreateModerationRequestInputVariant3ItemVariant1ImageUrl imageUrl)
        {
            return new CreateModerationRequestInputVariant3ItemVariant1
            {
                ImageUrl = imageUrl,
            };
        }

    }
}