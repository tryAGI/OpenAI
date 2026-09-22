
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Encrypted content exchanged between agents.
    /// </summary>
    public sealed partial class EncryptedContentResource
    {
        /// <summary>
        /// The content type. Always `encrypted_content`.<br/>
        /// Default Value: encrypted_content
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EncryptedContentResourceType.EncryptedContent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EncryptedContentResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.EncryptedContentResourceType Type { get; set; } = global::tryAGI.OpenAI.EncryptedContentResourceType.EncryptedContent;

        /// <summary>
        /// The encrypted content payload.
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
        /// Initializes a new instance of the <see cref="EncryptedContentResource" /> class.
        /// </summary>
        /// <param name="encryptedContent">
        /// The encrypted content payload.
        /// </param>
        /// <param name="type">
        /// The content type. Always `encrypted_content`.<br/>
        /// Default Value: encrypted_content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EncryptedContentResource(
            string encryptedContent,
            global::tryAGI.OpenAI.EncryptedContentResourceType type = global::tryAGI.OpenAI.EncryptedContentResourceType.EncryptedContent)
        {
            this.Type = type;
            this.EncryptedContent = encryptedContent ?? throw new global::System.ArgumentNullException(nameof(encryptedContent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedContentResource" /> class.
        /// </summary>
        public EncryptedContentResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="EncryptedContentResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static EncryptedContentResource FromEncryptedContent(string encryptedContent)
        {
            return new EncryptedContentResource
            {
                EncryptedContent = encryptedContent,
            };
        }

    }
}