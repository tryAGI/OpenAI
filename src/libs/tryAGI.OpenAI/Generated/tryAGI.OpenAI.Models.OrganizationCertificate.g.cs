
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an individual certificate configured at the organization level.
    /// </summary>
    public sealed partial class OrganizationCertificate
    {
        /// <summary>
        /// The object type, which is always `organization.certificate`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationCertificateObjectJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationCertificateObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the certificate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the certificate was uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.OrganizationCertificateCertificateDetails CertificateDetails { get; set; }

        /// <summary>
        /// Whether the certificate is currently active at the organization level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCertificate" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the certificate was uploaded.
        /// </param>
        /// <param name="certificateDetails"></param>
        /// <param name="active">
        /// Whether the certificate is currently active at the organization level.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.certificate`.
        /// </param>
        /// <param name="name">
        /// The name of the certificate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCertificate(
            string id,
            int createdAt,
            global::tryAGI.OpenAI.OrganizationCertificateCertificateDetails certificateDetails,
            bool active,
            global::tryAGI.OpenAI.OrganizationCertificateObject @object,
            string? name)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.CreatedAt = createdAt;
            this.CertificateDetails = certificateDetails ?? throw new global::System.ArgumentNullException(nameof(certificateDetails));
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCertificate" /> class.
        /// </summary>
        public OrganizationCertificate()
        {
        }
    }
}