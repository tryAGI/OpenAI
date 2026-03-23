
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum AuditLogEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyUpdated,
        /// <summary>
        /// 
        /// </summary>
        CertificateCreated,
        /// <summary>
        /// 
        /// </summary>
        CertificateDeleted,
        /// <summary>
        /// 
        /// </summary>
        CertificateUpdated,
        /// <summary>
        /// 
        /// </summary>
        CertificatesActivated,
        /// <summary>
        /// 
        /// </summary>
        CertificatesDeactivated,
        /// <summary>
        /// 
        /// </summary>
        CheckpointPermissionCreated,
        /// <summary>
        /// 
        /// </summary>
        CheckpointPermissionDeleted,
        /// <summary>
        /// 
        /// </summary>
        ExternalKeyRegistered,
        /// <summary>
        /// 
        /// </summary>
        ExternalKeyRemoved,
        /// <summary>
        /// 
        /// </summary>
        GroupCreated,
        /// <summary>
        /// 
        /// </summary>
        GroupDeleted,
        /// <summary>
        /// 
        /// </summary>
        GroupUpdated,
        /// <summary>
        /// 
        /// </summary>
        InviteAccepted,
        /// <summary>
        /// 
        /// </summary>
        InviteDeleted,
        /// <summary>
        /// 
        /// </summary>
        InviteSent,
        /// <summary>
        /// 
        /// </summary>
        IpAllowlistConfigActivated,
        /// <summary>
        /// 
        /// </summary>
        IpAllowlistConfigDeactivated,
        /// <summary>
        /// 
        /// </summary>
        IpAllowlistCreated,
        /// <summary>
        /// 
        /// </summary>
        IpAllowlistDeleted,
        /// <summary>
        /// 
        /// </summary>
        IpAllowlistUpdated,
        /// <summary>
        /// 
        /// </summary>
        LoginFailed,
        /// <summary>
        /// 
        /// </summary>
        LoginSucceeded,
        /// <summary>
        /// 
        /// </summary>
        LogoutFailed,
        /// <summary>
        /// 
        /// </summary>
        LogoutSucceeded,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectArchived,
        /// <summary>
        /// 
        /// </summary>
        ProjectCreated,
        /// <summary>
        /// 
        /// </summary>
        ProjectDeleted,
        /// <summary>
        /// 
        /// </summary>
        ProjectUpdated,
        /// <summary>
        /// 
        /// </summary>
        RateLimitDeleted,
        /// <summary>
        /// 
        /// </summary>
        RateLimitUpdated,
        /// <summary>
        /// 
        /// </summary>
        ResourceDeleted,
        /// <summary>
        /// 
        /// </summary>
        RoleAssignmentCreated,
        /// <summary>
        /// 
        /// </summary>
        RoleAssignmentDeleted,
        /// <summary>
        /// 
        /// </summary>
        RoleCreated,
        /// <summary>
        /// 
        /// </summary>
        RoleDeleted,
        /// <summary>
        /// 
        /// </summary>
        RoleUpdated,
        /// <summary>
        /// 
        /// </summary>
        ScimDisabled,
        /// <summary>
        /// 
        /// </summary>
        ScimEnabled,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountCreated,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountDeleted,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountUpdated,
        /// <summary>
        /// 
        /// </summary>
        TunnelCreated,
        /// <summary>
        /// 
        /// </summary>
        TunnelDeleted,
        /// <summary>
        /// 
        /// </summary>
        TunnelUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserAdded,
        /// <summary>
        /// 
        /// </summary>
        UserDeleted,
        /// <summary>
        /// 
        /// </summary>
        UserUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogEventType value)
        {
            return value switch
            {
                AuditLogEventType.ApiKeyCreated => "api_key.created",
                AuditLogEventType.ApiKeyDeleted => "api_key.deleted",
                AuditLogEventType.ApiKeyUpdated => "api_key.updated",
                AuditLogEventType.CertificateCreated => "certificate.created",
                AuditLogEventType.CertificateDeleted => "certificate.deleted",
                AuditLogEventType.CertificateUpdated => "certificate.updated",
                AuditLogEventType.CertificatesActivated => "certificates.activated",
                AuditLogEventType.CertificatesDeactivated => "certificates.deactivated",
                AuditLogEventType.CheckpointPermissionCreated => "checkpoint.permission.created",
                AuditLogEventType.CheckpointPermissionDeleted => "checkpoint.permission.deleted",
                AuditLogEventType.ExternalKeyRegistered => "external_key.registered",
                AuditLogEventType.ExternalKeyRemoved => "external_key.removed",
                AuditLogEventType.GroupCreated => "group.created",
                AuditLogEventType.GroupDeleted => "group.deleted",
                AuditLogEventType.GroupUpdated => "group.updated",
                AuditLogEventType.InviteAccepted => "invite.accepted",
                AuditLogEventType.InviteDeleted => "invite.deleted",
                AuditLogEventType.InviteSent => "invite.sent",
                AuditLogEventType.IpAllowlistConfigActivated => "ip_allowlist.config.activated",
                AuditLogEventType.IpAllowlistConfigDeactivated => "ip_allowlist.config.deactivated",
                AuditLogEventType.IpAllowlistCreated => "ip_allowlist.created",
                AuditLogEventType.IpAllowlistDeleted => "ip_allowlist.deleted",
                AuditLogEventType.IpAllowlistUpdated => "ip_allowlist.updated",
                AuditLogEventType.LoginFailed => "login.failed",
                AuditLogEventType.LoginSucceeded => "login.succeeded",
                AuditLogEventType.LogoutFailed => "logout.failed",
                AuditLogEventType.LogoutSucceeded => "logout.succeeded",
                AuditLogEventType.OrganizationUpdated => "organization.updated",
                AuditLogEventType.ProjectArchived => "project.archived",
                AuditLogEventType.ProjectCreated => "project.created",
                AuditLogEventType.ProjectDeleted => "project.deleted",
                AuditLogEventType.ProjectUpdated => "project.updated",
                AuditLogEventType.RateLimitDeleted => "rate_limit.deleted",
                AuditLogEventType.RateLimitUpdated => "rate_limit.updated",
                AuditLogEventType.ResourceDeleted => "resource.deleted",
                AuditLogEventType.RoleAssignmentCreated => "role.assignment.created",
                AuditLogEventType.RoleAssignmentDeleted => "role.assignment.deleted",
                AuditLogEventType.RoleCreated => "role.created",
                AuditLogEventType.RoleDeleted => "role.deleted",
                AuditLogEventType.RoleUpdated => "role.updated",
                AuditLogEventType.ScimDisabled => "scim.disabled",
                AuditLogEventType.ScimEnabled => "scim.enabled",
                AuditLogEventType.ServiceAccountCreated => "service_account.created",
                AuditLogEventType.ServiceAccountDeleted => "service_account.deleted",
                AuditLogEventType.ServiceAccountUpdated => "service_account.updated",
                AuditLogEventType.TunnelCreated => "tunnel.created",
                AuditLogEventType.TunnelDeleted => "tunnel.deleted",
                AuditLogEventType.TunnelUpdated => "tunnel.updated",
                AuditLogEventType.UserAdded => "user.added",
                AuditLogEventType.UserDeleted => "user.deleted",
                AuditLogEventType.UserUpdated => "user.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogEventType? ToEnum(string value)
        {
            return value switch
            {
                "api_key.created" => AuditLogEventType.ApiKeyCreated,
                "api_key.deleted" => AuditLogEventType.ApiKeyDeleted,
                "api_key.updated" => AuditLogEventType.ApiKeyUpdated,
                "certificate.created" => AuditLogEventType.CertificateCreated,
                "certificate.deleted" => AuditLogEventType.CertificateDeleted,
                "certificate.updated" => AuditLogEventType.CertificateUpdated,
                "certificates.activated" => AuditLogEventType.CertificatesActivated,
                "certificates.deactivated" => AuditLogEventType.CertificatesDeactivated,
                "checkpoint.permission.created" => AuditLogEventType.CheckpointPermissionCreated,
                "checkpoint.permission.deleted" => AuditLogEventType.CheckpointPermissionDeleted,
                "external_key.registered" => AuditLogEventType.ExternalKeyRegistered,
                "external_key.removed" => AuditLogEventType.ExternalKeyRemoved,
                "group.created" => AuditLogEventType.GroupCreated,
                "group.deleted" => AuditLogEventType.GroupDeleted,
                "group.updated" => AuditLogEventType.GroupUpdated,
                "invite.accepted" => AuditLogEventType.InviteAccepted,
                "invite.deleted" => AuditLogEventType.InviteDeleted,
                "invite.sent" => AuditLogEventType.InviteSent,
                "ip_allowlist.config.activated" => AuditLogEventType.IpAllowlistConfigActivated,
                "ip_allowlist.config.deactivated" => AuditLogEventType.IpAllowlistConfigDeactivated,
                "ip_allowlist.created" => AuditLogEventType.IpAllowlistCreated,
                "ip_allowlist.deleted" => AuditLogEventType.IpAllowlistDeleted,
                "ip_allowlist.updated" => AuditLogEventType.IpAllowlistUpdated,
                "login.failed" => AuditLogEventType.LoginFailed,
                "login.succeeded" => AuditLogEventType.LoginSucceeded,
                "logout.failed" => AuditLogEventType.LogoutFailed,
                "logout.succeeded" => AuditLogEventType.LogoutSucceeded,
                "organization.updated" => AuditLogEventType.OrganizationUpdated,
                "project.archived" => AuditLogEventType.ProjectArchived,
                "project.created" => AuditLogEventType.ProjectCreated,
                "project.deleted" => AuditLogEventType.ProjectDeleted,
                "project.updated" => AuditLogEventType.ProjectUpdated,
                "rate_limit.deleted" => AuditLogEventType.RateLimitDeleted,
                "rate_limit.updated" => AuditLogEventType.RateLimitUpdated,
                "resource.deleted" => AuditLogEventType.ResourceDeleted,
                "role.assignment.created" => AuditLogEventType.RoleAssignmentCreated,
                "role.assignment.deleted" => AuditLogEventType.RoleAssignmentDeleted,
                "role.created" => AuditLogEventType.RoleCreated,
                "role.deleted" => AuditLogEventType.RoleDeleted,
                "role.updated" => AuditLogEventType.RoleUpdated,
                "scim.disabled" => AuditLogEventType.ScimDisabled,
                "scim.enabled" => AuditLogEventType.ScimEnabled,
                "service_account.created" => AuditLogEventType.ServiceAccountCreated,
                "service_account.deleted" => AuditLogEventType.ServiceAccountDeleted,
                "service_account.updated" => AuditLogEventType.ServiceAccountUpdated,
                "tunnel.created" => AuditLogEventType.TunnelCreated,
                "tunnel.deleted" => AuditLogEventType.TunnelDeleted,
                "tunnel.updated" => AuditLogEventType.TunnelUpdated,
                "user.added" => AuditLogEventType.UserAdded,
                "user.deleted" => AuditLogEventType.UserDeleted,
                "user.updated" => AuditLogEventType.UserUpdated,
                _ => null,
            };
        }
    }
}