
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The image output from the code interpreter.
    /// </summary>
    public sealed partial class BetaCodeInterpreterOutputImage
    {
        /// <summary>
        /// The type of the output. Always `image`.<br/>
        /// Default Value: image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType.Image</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType Type { get; set; } = global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType.Image;

        /// <summary>
        /// The URL of the image output from the code interpreter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCodeInterpreterOutputImage" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the image output from the code interpreter.
        /// </param>
        /// <param name="type">
        /// The type of the output. Always `image`.<br/>
        /// Default Value: image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCodeInterpreterOutputImage(
            string url,
            global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType type = global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType.Image)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCodeInterpreterOutputImage" /> class.
        /// </summary>
        public BetaCodeInterpreterOutputImage()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaCodeInterpreterOutputImage"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaCodeInterpreterOutputImage FromUrl(string url)
        {
            return new BetaCodeInterpreterOutputImage
            {
                Url = url,
            };
        }

    }
}