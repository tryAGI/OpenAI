
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GcpExternalStorageProviderResponse
    {
        /// <summary>
        /// Default Value: gcp
        /// </summary>
        /// <default>global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType.Gcp</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GcpExternalStorageProviderResponseTypeJsonConverter))]
        public global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType Type { get; set; } = global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType.Gcp;

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpExternalStorageProviderResponse" /> class.
        /// </summary>
        /// <param name="bucket"></param>
        /// <param name="workloadIdentityProjectNumber"></param>
        /// <param name="workloadIdentityPoolId"></param>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="region"></param>
        /// <param name="audience"></param>
        /// <param name="type">
        /// Default Value: gcp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GcpExternalStorageProviderResponse(
            string bucket,
            string workloadIdentityProjectNumber,
            string workloadIdentityPoolId,
            string workloadIdentityProviderId,
            string region,
            string audience,
            global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType type = global::tryAGI.OpenAI.GcpExternalStorageProviderResponseType.Gcp)
        {
            this.Type = type;
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.WorkloadIdentityProjectNumber = workloadIdentityProjectNumber ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProjectNumber));
            this.WorkloadIdentityPoolId = workloadIdentityPoolId ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityPoolId));
            this.WorkloadIdentityProviderId = workloadIdentityProviderId ?? throw new global::System.ArgumentNullException(nameof(workloadIdentityProviderId));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GcpExternalStorageProviderResponse" /> class.
        /// </summary>
        public GcpExternalStorageProviderResponse()
        {
        }

    }
}