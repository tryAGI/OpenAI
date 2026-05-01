
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationCertificateCertificateDetails
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the certificate becomes valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_at")]
        public int? ValidAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the certificate expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCertificateCertificateDetails" /> class.
        /// </summary>
        /// <param name="validAt">
        /// The Unix timestamp (in seconds) of when the certificate becomes valid.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) of when the certificate expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCertificateCertificateDetails(
            int? validAt,
            int? expiresAt)
        {
            this.ValidAt = validAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCertificateCertificateDetails" /> class.
        /// </summary>
        public OrganizationCertificateCertificateDetails()
        {
        }
    }
}