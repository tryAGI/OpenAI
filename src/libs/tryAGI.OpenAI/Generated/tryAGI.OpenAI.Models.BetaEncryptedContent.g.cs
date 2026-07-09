
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Opaque encrypted content that Responses API decrypts inside trusted model execution.
    /// </summary>
    public sealed partial class BetaEncryptedContent
    {
        /// <summary>
        /// The type of the input item. Always `encrypted_content`.<br/>
        /// Default Value: encrypted_content
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaEncryptedContentType.EncryptedContent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaEncryptedContentType Type { get; set; } = global::tryAGI.OpenAI.BetaEncryptedContentType.EncryptedContent;

        /// <summary>
        /// Opaque encrypted content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEncryptedContent" /> class.
        /// </summary>
        /// <param name="encryptedContent">
        /// Opaque encrypted content.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `encrypted_content`.<br/>
        /// Default Value: encrypted_content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEncryptedContent(
            string encryptedContent,
            global::tryAGI.OpenAI.BetaEncryptedContentType type = global::tryAGI.OpenAI.BetaEncryptedContentType.EncryptedContent)
        {
            this.Type = type;
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEncryptedContent" /> class.
        /// </summary>
        public BetaEncryptedContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaEncryptedContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaEncryptedContent FromEncryptedContent(string encryptedContent)
        {
            return new BetaEncryptedContent
            {
                EncryptedContent = encryptedContent,
            };
        }

    }
}