
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an individual certificate configured at the project level.
    /// </summary>
    public sealed partial class OrganizationProjectCertificate
    {
        /// <summary>
        /// The object type, which is always `organization.project.certificate`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationProjectCertificateObjectJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationProjectCertificateObject Object { get; set; }

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
        public required global::tryAGI.OpenAI.OrganizationProjectCertificateCertificateDetails CertificateDetails { get; set; }

        /// <summary>
        /// Whether the certificate is currently active at the project level.
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
        /// Initializes a new instance of the <see cref="OrganizationProjectCertificate" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the certificate was uploaded.
        /// </param>
        /// <param name="certificateDetails"></param>
        /// <param name="active">
        /// Whether the certificate is currently active at the project level.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.project.certificate`.
        /// </param>
        /// <param name="name">
        /// The name of the certificate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationProjectCertificate(
            string id,
            int createdAt,
            global::tryAGI.OpenAI.OrganizationProjectCertificateCertificateDetails certificateDetails,
            bool active,
            global::tryAGI.OpenAI.OrganizationProjectCertificateObject @object,
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
        /// Initializes a new instance of the <see cref="OrganizationProjectCertificate" /> class.
        /// </summary>
        public OrganizationProjectCertificate()
        {
        }
    }
}