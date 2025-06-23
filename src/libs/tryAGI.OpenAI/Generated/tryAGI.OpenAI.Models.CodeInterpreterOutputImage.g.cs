
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The image output from the code interpreter.
    /// </summary>
    public sealed partial class CodeInterpreterOutputImage
    {
        /// <summary>
        /// The type of the output. Always 'image'.<br/>
        /// Default Value: image
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CodeInterpreterOutputImageType.Image</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputImageTypeJsonConverter))]
        public global::tryAGI.OpenAI.CodeInterpreterOutputImageType Type { get; set; } = global::tryAGI.OpenAI.CodeInterpreterOutputImageType.Image;

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
        /// Initializes a new instance of the <see cref="CodeInterpreterOutputImage" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the output. Always 'image'.<br/>
        /// Default Value: image
        /// </param>
        /// <param name="url">
        /// The URL of the image output from the code interpreter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterOutputImage(
            string url,
            global::tryAGI.OpenAI.CodeInterpreterOutputImageType type = global::tryAGI.OpenAI.CodeInterpreterOutputImageType.Image)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterOutputImage" /> class.
        /// </summary>
        public CodeInterpreterOutputImage()
        {
        }
    }
}