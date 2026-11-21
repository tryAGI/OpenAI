
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationCertificateActivationResponse
    {
        /// <summary>
        /// The organization certificate activation result type.
        /// </summary>
        /// <default>"organization.certificate.activation"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "organization.certificate.activation";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationCertificate> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCertificateActivationResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object">
        /// The organization certificate activation result type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCertificateActivationResponse(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationCertificate> data,
            string @object = "organization.certificate.activation")
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCertificateActivationResponse" /> class.
        /// </summary>
        public OrganizationCertificateActivationResponse()
        {
        }

    }
}