
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The payload used to update the role.
    /// </summary>
    public sealed partial class AuditLogRoleUpdatedChangesRequested
    {
        /// <summary>
        /// The updated role name, when provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// The resource the role is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// The type of resource the role belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// The permissions added to the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_added")]
        public global::System.Collections.Generic.IList<string>? PermissionsAdded { get; set; }

        /// <summary>
        /// The permissions removed from the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_removed")]
        public global::System.Collections.Generic.IList<string>? PermissionsRemoved { get; set; }

        /// <summary>
        /// The updated role description, when provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional metadata stored on the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRoleUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="roleName">
        /// The updated role name, when provided.
        /// </param>
        /// <param name="resourceId">
        /// The resource the role is scoped to.
        /// </param>
        /// <param name="resourceType">
        /// The type of resource the role belongs to.
        /// </param>
        /// <param name="permissionsAdded">
        /// The permissions added to the role.
        /// </param>
        /// <param name="permissionsRemoved">
        /// The permissions removed from the role.
        /// </param>
        /// <param name="description">
        /// The updated role description, when provided.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata stored on the role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogRoleUpdatedChangesRequested(
            string? roleName,
            string? resourceId,
            string? resourceType,
            global::System.Collections.Generic.IList<string>? permissionsAdded,
            global::System.Collections.Generic.IList<string>? permissionsRemoved,
            string? description,
            object? metadata)
        {
            this.RoleName = roleName;
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
            this.PermissionsAdded = permissionsAdded;
            this.PermissionsRemoved = permissionsRemoved;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRoleUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogRoleUpdatedChangesRequested()
        {
        }
    }
}