
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogWorkloadIdentityProviderDeleted
    {
        /// <summary>
        /// The workload identity provider ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The workload identity provider name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogWorkloadIdentityProviderDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The workload identity provider ID.
        /// </param>
        /// <param name="name">
        /// The workload identity provider name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogWorkloadIdentityProviderDeleted(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogWorkloadIdentityProviderDeleted" /> class.
        /// </summary>
        public AuditLogWorkloadIdentityProviderDeleted()
        {
        }

    }
}