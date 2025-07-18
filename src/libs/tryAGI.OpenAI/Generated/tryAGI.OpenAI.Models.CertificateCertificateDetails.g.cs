
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CertificateCertificateDetails
    {
        /// <summary>
        /// The content of the certificate in PEM format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the certificate expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the certificate becomes valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ValidAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCertificateDetails" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the certificate in PEM format.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) of when the certificate expires.
        /// </param>
        /// <param name="validAt">
        /// The Unix timestamp (in seconds) of when the certificate becomes valid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CertificateCertificateDetails(
            string? content,
            global::System.DateTimeOffset? expiresAt,
            global::System.DateTimeOffset? validAt)
        {
            this.Content = content;
            this.ExpiresAt = expiresAt;
            this.ValidAt = validAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCertificateDetails" /> class.
        /// </summary>
        public CertificateCertificateDetails()
        {
        }
    }
}