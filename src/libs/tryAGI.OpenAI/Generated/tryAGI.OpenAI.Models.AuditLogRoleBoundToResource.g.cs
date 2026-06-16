
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogRoleBoundToResource
    {
        /// <summary>
        /// The ID of the resource the role was bound to. ChatGPT workspace connector resources use `&lt;workspace_id&gt;__&lt;connector_id&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The ID of the role that was bound to the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public string? RoleId { get; set; }

        /// <summary>
        /// The ID of the resource the role was bound to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// The type of resource the role was bound to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// The permissions granted to the role for the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// The workspace ID for a ChatGPT workspace connector resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// The connector ID for a ChatGPT workspace connector resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// The connector display name for a ChatGPT workspace connector resource, or the connector ID when the display name could not be resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_name")]
        public string? ConnectorName { get; set; }

        /// <summary>
        /// Whether the connector is enabled for the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The connector role mutation path that produced the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogRoleBoundToResourceSourceJsonConverter))]
        public global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRoleBoundToResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the resource the role was bound to. ChatGPT workspace connector resources use `&lt;workspace_id&gt;__&lt;connector_id&gt;`.
        /// </param>
        /// <param name="roleId">
        /// The ID of the role that was bound to the resource.
        /// </param>
        /// <param name="resourceId">
        /// The ID of the resource the role was bound to.
        /// </param>
        /// <param name="resourceType">
        /// The type of resource the role was bound to.
        /// </param>
        /// <param name="permissions">
        /// The permissions granted to the role for the resource.
        /// </param>
        /// <param name="workspaceId">
        /// The workspace ID for a ChatGPT workspace connector resource.
        /// </param>
        /// <param name="connectorId">
        /// The connector ID for a ChatGPT workspace connector resource.
        /// </param>
        /// <param name="connectorName">
        /// The connector display name for a ChatGPT workspace connector resource, or the connector ID when the display name could not be resolved.
        /// </param>
        /// <param name="enabled">
        /// Whether the connector is enabled for the role.
        /// </param>
        /// <param name="source">
        /// The connector role mutation path that produced the event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogRoleBoundToResource(
            string? id,
            string? roleId,
            string? resourceId,
            string? resourceType,
            global::System.Collections.Generic.IList<string>? permissions,
            string? workspaceId,
            string? connectorId,
            string? connectorName,
            bool? enabled,
            global::tryAGI.OpenAI.AuditLogRoleBoundToResourceSource? source)
        {
            this.Id = id;
            this.RoleId = roleId;
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
            this.Permissions = permissions;
            this.WorkspaceId = workspaceId;
            this.ConnectorId = connectorId;
            this.ConnectorName = connectorName;
            this.Enabled = enabled;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRoleBoundToResource" /> class.
        /// </summary>
        public AuditLogRoleBoundToResource()
        {
        }

    }
}