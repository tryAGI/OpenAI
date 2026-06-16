
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The connector role mutation path that produced the event.
    /// </summary>
    public enum AuditLogRoleUnboundFromResourceSource
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
    public static class AuditLogRoleUnboundFromResourceSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogRoleUnboundFromResourceSource value)
        {
            return value switch
            {
                AuditLogRoleUnboundFromResourceSource.ConnectorPublish => "connector_publish",
                AuditLogRoleUnboundFromResourceSource.RoleConnectorUpdate => "role_connector_update",
                AuditLogRoleUnboundFromResourceSource.RoleDelete => "role_delete",
                AuditLogRoleUnboundFromResourceSource.RoleToggle => "role_toggle",
                AuditLogRoleUnboundFromResourceSource.WorkspacePermissions => "workspace_permissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogRoleUnboundFromResourceSource? ToEnum(string value)
        {
            return value switch
            {
                "connector_publish" => AuditLogRoleUnboundFromResourceSource.ConnectorPublish,
                "role_connector_update" => AuditLogRoleUnboundFromResourceSource.RoleConnectorUpdate,
                "role_delete" => AuditLogRoleUnboundFromResourceSource.RoleDelete,
                "role_toggle" => AuditLogRoleUnboundFromResourceSource.RoleToggle,
                "workspace_permissions" => AuditLogRoleUnboundFromResourceSource.WorkspacePermissions,
                _ => null,
            };
        }
    }
}