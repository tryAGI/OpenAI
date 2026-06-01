
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogWorkloadIdentityProviderMappingUpdated
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
        /// The payload used to update the workload identity provider mapping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes_requested")]
        public object? ChangesRequested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogWorkloadIdentityProviderMappingUpdated" /> class.
        /// </summary>
        /// <param name="id">
        /// The workload identity provider mapping ID.
        /// </param>
        /// <param name="identityProviderId">
        /// The workload identity provider ID.
        /// </param>
        /// <param name="changesRequested">
        /// The payload used to update the workload identity provider mapping.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogWorkloadIdentityProviderMappingUpdated(
            string? id,
            string? identityProviderId,
            object? changesRequested)
        {
            this.Id = id;
            this.IdentityProviderId = identityProviderId;
            this.ChangesRequested = changesRequested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogWorkloadIdentityProviderMappingUpdated" /> class.
        /// </summary>
        public AuditLogWorkloadIdentityProviderMappingUpdated()
        {
        }

    }
}