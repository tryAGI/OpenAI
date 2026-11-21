
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteCertificateResponse
    {
        /// <summary>
        /// The object type, must be `certificate.deleted`.
        /// </summary>
        /// <default>"certificate.deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "certificate.deleted";

        /// <summary>
        /// The ID of the certificate that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCertificateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the certificate that was deleted.
        /// </param>
        /// <param name="object">
        /// The object type, must be `certificate.deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteCertificateResponse(
            string id,
            string @object = "certificate.deleted")
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCertificateResponse" /> class.
        /// </summary>
        public DeleteCertificateResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DeleteCertificateResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DeleteCertificateResponse FromId(string id)
        {
            return new DeleteCertificateResponse
            {
                Id = id,
            };
        }

    }
}