
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogWorkloadIdentityProviderMappingDeleted
    {
        /// <summary>
        /// The workload identity provider mapping ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The workload identity provider ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_provider_id")]
        public string? IdentityProviderId { get; set; }

        /// <summary>
        /// The project ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The mapped service account ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        public string? ServiceAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogWorkloadIdentityProviderMappingDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The workload identity provider mapping ID.
        /// </param>
        /// <param name="identityProviderId">
        /// The workload identity provider ID.
        /// </param>
        /// <param name="projectId">
        /// The project ID.
        /// </param>
        /// <param name="serviceAccountId">
        /// The mapped service account ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogWorkloadIdentityProviderMappingDeleted(
            string? id,
            string? identityProviderId,
            string? projectId,
            string? serviceAccountId)
        {
            this.Id = id;
            this.IdentityProviderId = identityProviderId;
            this.ProjectId = projectId;
            this.ServiceAccountId = serviceAccountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogWorkloadIdentityProviderMappingDeleted" /> class.
        /// </summary>
        public AuditLogWorkloadIdentityProviderMappingDeleted()
        {
        }

    }
}