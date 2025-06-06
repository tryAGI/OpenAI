
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToggleCertificatesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CertificateIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleCertificatesRequest" /> class.
        /// </summary>
        /// <param name="certificateIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToggleCertificatesRequest(
            global::System.Collections.Generic.IList<string> certificateIds)
        {
            this.CertificateIds = certificateIds ?? throw new global::System.ArgumentNullException(nameof(certificateIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleCertificatesRequest" /> class.
        /// </summary>
        public ToggleCertificatesRequest()
        {
        }
    }
}