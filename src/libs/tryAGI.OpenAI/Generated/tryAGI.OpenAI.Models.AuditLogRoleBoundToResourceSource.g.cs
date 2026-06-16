
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The connector role mutation path that produced the event.
    /// </summary>
    public enum AuditLogRoleBoundToResourceSource
    {
        /// <summary>
        /// 
        /// </summary>
        ConnectorPublish,
        /// <summary>
        /// 
        /// </summary>
        RoleConnectorUpdate,
        /// <summary>
        /// 
        /// </summary>
        RoleDelete,
        /// <summary>
        /// 
        /// </summary>
        RoleToggle,
        /// <summary>
        /// 
        /// </summary>
        WorkspacePermissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogRoleBoundToResourceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogRoleBoundToResourceSource value)
        {
            return value switch
            {
                AuditLogRoleBoundToResourceSource.ConnectorPublish => "connector_publish",
                AuditLogRoleBoundToResourceSource.RoleConnectorUpdate => "role_connector_update",
                AuditLogRoleBoundToResourceSource.RoleDelete => "role_delete",
                AuditLogRoleBoundToResourceSource.RoleToggle => "role_toggle",
                AuditLogRoleBoundToResourceSource.WorkspacePermissions => "workspace_permissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogRoleBoundToResourceSource? ToEnum(string value)
        {
            return value switch
            {
                "connector_publish" => AuditLogRoleBoundToResourceSource.ConnectorPublish,
                "role_connector_update" => AuditLogRoleBoundToResourceSource.RoleConnectorUpdate,
                "role_delete" => AuditLogRoleBoundToResourceSource.RoleDelete,
                "role_toggle" => AuditLogRoleBoundToResourceSource.RoleToggle,
                "workspace_permissions" => AuditLogRoleBoundToResourceSource.WorkspacePermissions,
                _ => null,
            };
        }
    }
}