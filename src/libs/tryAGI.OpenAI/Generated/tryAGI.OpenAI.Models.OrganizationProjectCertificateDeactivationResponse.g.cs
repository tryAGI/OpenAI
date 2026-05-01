
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationProjectCertificateDeactivationResponse
    {
        /// <summary>
        /// The project certificate deactivation result type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.OrganizationProjectCertificateDeactivationResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationProjectCertificate> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectCertificateDeactivationResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object">
        /// The project certificate deactivation result type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationProjectCertificateDeactivationResponse(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OrganizationProjectCertificate> data,
            global::tryAGI.OpenAI.OrganizationProjectCertificateDeactivationResponseObject @object)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectCertificateDeactivationResponse" /> class.
        /// </summary>
        public OrganizationProjectCertificateDeactivationResponse()
        {
        }
    }
}