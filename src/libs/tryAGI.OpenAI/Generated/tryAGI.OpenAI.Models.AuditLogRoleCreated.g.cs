
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogRoleCreated
    {
        /// <summary>
        /// The role ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// The permissions granted by the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// The type of resource the role belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// The resource the role is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRoleCreated" /> class.
        /// </summary>
        /// <param name="id">
        /// The role ID.
        /// </param>
        /// <param name="roleName">
        /// The name of the role.
        /// </param>
        /// <param name="permissions">
        /// The permissions granted by the role.
        /// </param>
        /// <param name="resourceType">
        /// The type of resource the role belongs to.
        /// </param>
        /// <param name="resourceId">
        /// The resource the role is scoped to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogRoleCreated(
            string? id,
            string? roleName,
            global::System.Collections.Generic.IList<string>? permissions,
            string? resourceType,
            string? resourceId)
        {
            this.Id = id;
            this.RoleName = roleName;
            this.Permissions = permissions;
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRoleCreated" /> class.
        /// </summary>
        public AuditLogRoleCreated()
        {
        }
    }
}