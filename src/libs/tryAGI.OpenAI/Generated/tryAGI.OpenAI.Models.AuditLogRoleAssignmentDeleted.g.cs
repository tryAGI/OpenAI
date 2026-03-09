
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogRoleAssignmentDeleted
    {
        /// <summary>
        /// The identifier of the role assignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The principal (user or group) that had the role removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal_id")]
        public string? PrincipalId { get; set; }

        /// <summary>
        /// The type of principal (user or group) that had the role removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("principal_type")]
        public string? PrincipalType { get; set; }

        /// <summary>
        /// The resource the role assignment was scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// The type of resource the role assignment was scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRoleAssignmentDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the role assignment.
        /// </param>
        /// <param name="principalId">
        /// The principal (user or group) that had the role removed.
        /// </param>
        /// <param name="principalType">
        /// The type of principal (user or group) that had the role removed.
        /// </param>
        /// <param name="resourceId">
        /// The resource the role assignment was scoped to.
        /// </param>
        /// <param name="resourceType">
        /// The type of resource the role assignment was scoped to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogRoleAssignmentDeleted(
            string? id,
            string? principalId,
            string? principalType,
            string? resourceId,
            string? resourceType)
        {
            this.Id = id;
            this.PrincipalId = principalId;
            this.PrincipalType = principalType;
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRoleAssignmentDeleted" /> class.
        /// </summary>
        public AuditLogRoleAssignmentDeleted()
        {
        }
    }
}