
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExternalKeyResource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ExternalKeyPurposeJsonConverter))]
        public global::tryAGI.OpenAI.ExternalKeyPurpose? Purpose { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_project_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ApiProjectIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_arn")]
        public string? RoleArn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_arn")]
        public string? KmsArn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_project_number")]
        public string? WorkloadIdentityProjectNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_pool_id")]
        public string? WorkloadIdentityPoolId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_identity_provider_id")]
        public string? WorkloadIdentityProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_project_id")]
        public string? KmsProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_ring_name")]
        public string? KmsKeyRingName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_name")]
        public string? KmsKeyName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_location")]
        public string? KmsKeyLocation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kms_key_version")]
        public string? KmsKeyVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vault_uri")]
        public string? VaultUri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        public string? KeyName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_version")]
        public string? KeyVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalKeyResource" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="apiProjectIds"></param>
        /// <param name="workspaceId"></param>
        /// <param name="createdAt"></param>
        /// <param name="purpose"></param>
        /// <param name="roleArn"></param>
        /// <param name="externalId"></param>
        /// <param name="kmsArn"></param>
        /// <param name="workloadIdentityProjectNumber"></param>
        /// <param name="workloadIdentityPoolId"></param>
        /// <param name="workloadIdentityProviderId"></param>
        /// <param name="audience"></param>
        /// <param name="kmsProjectId"></param>
        /// <param name="kmsKeyRingName"></param>
        /// <param name="kmsKeyName"></param>
        /// <param name="kmsKeyLocation"></param>
        /// <param name="kmsKeyVersion"></param>
        /// <param name="tenantId"></param>
        /// <param name="vaultUri"></param>
        /// <param name="keyName"></param>
        /// <param name="keyVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalKeyResource(
            string @object,
            string id,
            string type,
            string name,
            global::System.Collections.Generic.IList<string> apiProjectIds,
            string workspaceId,
            int createdAt,
            global::tryAGI.OpenAI.ExternalKeyPurpose? purpose,
            string? roleArn,
            string? externalId,
            string? kmsArn,
            string? workloadIdentityProjectNumber,
            string? workloadIdentityPoolId,
            string? workloadIdentityProviderId,
            string? audience,
            string? kmsProjectId,
            string? kmsKeyRingName,
            string? kmsKeyName,
            string? kmsKeyLocation,
            string? kmsKeyVersion,
            string? tenantId,
            string? vaultUri,
            string? keyName,
            string? keyVersion)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Purpose = purpose;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApiProjectIds = apiProjectIds ?? throw new global::System.ArgumentNullException(nameof(apiProjectIds));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.CreatedAt = createdAt;
            this.RoleArn = roleArn;
            this.ExternalId = externalId;
            this.KmsArn = kmsArn;
            this.WorkloadIdentityProjectNumber = workloadIdentityProjectNumber;
            this.WorkloadIdentityPoolId = workloadIdentityPoolId;
            this.WorkloadIdentityProviderId = workloadIdentityProviderId;
            this.Audience = audience;
            this.KmsProjectId = kmsProjectId;
            this.KmsKeyRingName = kmsKeyRingName;
            this.KmsKeyName = kmsKeyName;
            this.KmsKeyLocation = kmsKeyLocation;
            this.KmsKeyVersion = kmsKeyVersion;
            this.TenantId = tenantId;
            this.VaultUri = vaultUri;
            this.KeyName = keyName;
            this.KeyVersion = keyVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalKeyResource" /> class.
        /// </summary>
        public ExternalKeyResource()
        {
        }

    }
}