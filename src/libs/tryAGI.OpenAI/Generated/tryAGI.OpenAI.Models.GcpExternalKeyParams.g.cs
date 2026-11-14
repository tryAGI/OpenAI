
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GcpExternalKeyParams
    {
        /// <summary>
        /// A friendly name to identify this config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: gcp
        /// </summary>
        /// <default>global::tryAGI.OpenAI.GcpExternalKeyParamsType.Gcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GcpExternalKeyParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.GcpExternalKeyParamsType Type { get; set; } = global::tryAGI.OpenAI.GcpExternalKeyParamsType.Gcp;

        /// <summary>
        /// The numeric GCP project number where you registered OpenAI's workload identity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityProjectNumber { get; set; }

        /// <summary>
        /// The pool containing the Workload Identity provider that you registered for OpenAI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_pool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityPoolId { get; set; }

        /// <summary>
        /// The Workload Identity provider that you registered for OpenAI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityProviderId { get; set; }

        /// <summary>
        /// The string GCP project name where your KMS resides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KmsProjectId { get; set; }

        /// <summary>
        /// The Key Management System key ring for the master key you manage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_ring_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KmsKeyRingName { get; set; }

        /// <summary>
        /// The name of the Key Management System master key you manage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KmsKeyName { get; set; }

        /// <summary>
        /// The region where your Key Management System master key is located
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KmsKeyLocation { get; set; }

        /// <summary>
        /// The aud field in the identity token OpenAI will pass in the call to the customer's GCP STS. This must be the OpenAI organization ID or an API project ID that belongs to the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ExternalKeyPurposeJsonConverter))]
        public global::tryAGI.OpenAI.ExternalKeyPurpose? Purpose { get; set; }

        /// <summary>
        /// An exact CryptoKeyVersion number. Required for PSP decryption; not accepted for EKM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_version")]
        public string? KmsKeyVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpExternalKeyParams" /> class.
        /// </summary>
        /// <param name="name">
        /// A friendly name to identify this config
        /// </param>
        /// <param name="workloadIdentityProjectNumber">
        /// The numeric GCP project number where you registered OpenAI's workload identity
        /// </param>
        /// <param name="workloadIdentityPoolId">
        /// The pool containing the Workload Identity provider that you registered for OpenAI
        /// </param>
        /// <param name="workloadIdentityProviderId">
        /// The Workload Identity provider that you registered for OpenAI
        /// </param>
        /// <param name="kmsProjectId">
        /// The string GCP project name where your KMS resides
        /// </param>
        /// <param name="kmsKeyRingName">
        /// The Key Management System key ring for the master key you manage
        /// </param>
        /// <param name="kmsKeyName">
        /// The name of the Key Management System master key you manage
        /// </param>
        /// <param name="kmsKeyLocation">
        /// The region where your Key Management System master key is located
        /// </param>
        /// <param name="audience">
        /// The aud field in the identity token OpenAI will pass in the call to the customer's GCP STS. This must be the OpenAI organization ID or an API project ID that belongs to the organization.
        /// </param>
        /// <param name="purpose"></param>
        /// <param name="kmsKeyVersion">
        /// An exact CryptoKeyVersion number. Required for PSP decryption; not accepted for EKM.
        /// </param>
        /// <param name="type">
        /// Default Value: gcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GcpExternalKeyParams(
            string name,
            string workloadIdentityProjectNumber,
            string workloadIdentityPoolId,
            string workloadIdentityProviderId,
            string kmsProjectId,
            string kmsKeyRingName,
            string kmsKeyName,
            string kmsKeyLocation,
            string audience,
            global::tryAGI.OpenAI.ExternalKeyPurpose? purpose,
            string? kmsKeyVersion,
            global::tryAGI.OpenAI.GcpExternalKeyParamsType type = global::tryAGI.OpenAI.GcpExternalKeyParamsType.Gcp)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.WorkloadIdentityProjectNumber = workloadIdentityProjectNumber ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProjectNumber));
            this.WorkloadIdentityPoolId = workloadIdentityPoolId ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityPoolId));
            this.WorkloadIdentityProviderId = workloadIdentityProviderId ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProviderId));
            this.KmsProjectId = kmsProjectId ?? throw new global::System.ArgumentNullException(nameof(kmsProjectId));
            this.KmsKeyRingName = kmsKeyRingName ?? throw new global::System.ArgumentNullException(nameof(kmsKeyRingName));
            this.KmsKeyName = kmsKeyName ?? throw new global::System.ArgumentNullException(nameof(kmsKeyName));
            this.KmsKeyLocation = kmsKeyLocation ?? throw new global::System.ArgumentNullException(nameof(kmsKeyLocation));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.Purpose = purpose;
            this.KmsKeyVersion = kmsKeyVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpExternalKeyParams" /> class.
        /// </summary>
        public GcpExternalKeyParams()
        {
        }

    }
}