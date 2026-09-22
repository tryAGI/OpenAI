
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GcpExternalStorageProviderParams
    {
        /// <summary>
        /// Default Value: gcp
        /// </summary>
        /// <default>global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType.Gcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GcpExternalStorageProviderParamsTypeJsonConverter))]
        public global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType Type { get; set; } = global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType.Gcp;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityProjectNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_pool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityPoolId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadIdentityProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpExternalStorageProviderParams" /> class.
        /// </summary>
        /// <param name="bucket"></param>
        /// <param name="workloadIdentityProjectNumber"></param>
        /// <param name="workloadIdentityPoolId"></param>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="type">
        /// Default Value: gcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GcpExternalStorageProviderParams(
            string bucket,
            string workloadIdentityProjectNumber,
            string workloadIdentityPoolId,
            string workloadIdentityProviderId,
            global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType type = global::tryAGI.OpenAI.GcpExternalStorageProviderParamsType.Gcp)
        {
            this.Type = type;
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.WorkloadIdentityProjectNumber = workloadIdentityProjectNumber ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProjectNumber));
            this.WorkloadIdentityPoolId = workloadIdentityPoolId ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityPoolId));
            this.WorkloadIdentityProviderId = workloadIdentityProviderId ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProviderId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpExternalStorageProviderParams" /> class.
        /// </summary>
        public GcpExternalStorageProviderParams()
        {
        }

    }
}