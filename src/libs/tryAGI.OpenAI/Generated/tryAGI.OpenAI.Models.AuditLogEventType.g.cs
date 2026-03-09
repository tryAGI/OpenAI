
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
        ApiKeyUpdated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        CertificateCreated,
        /// <summary>
        /// 
        /// </summary>
        CertificateUpdated,
        /// <summary>
        /// 
        /// </summary>
        CertificateDeleted,
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
        GroupUpdated,
        /// <summary>
        /// 
        /// </summary>
        GroupDeleted,
        /// <summary>
        /// 
        /// </summary>
        InviteSent,
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
        IpAllowlistCreated,
        /// <summary>
        /// 
        /// </summary>
        IpAllowlistUpdated,
        /// <summary>
        /// 
        /// </summary>
        IpAllowlistDeleted,
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
        LoginSucceeded,
        /// <summary>
        /// 
        /// </summary>
        LoginFailed,
        /// <summary>
        /// 
        /// </summary>
        LogoutSucceeded,
        /// <summary>
        /// 
        /// </summary>
        LogoutFailed,
        /// <summary>
        /// 
        /// </summary>
        OrganizationUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectCreated,
        /// <summary>
        /// 
        /// </summary>
        ProjectUpdated,
        /// <summary>
        /// 
        /// </summary>
        ProjectArchived,
        /// <summary>
        /// 
        /// </summary>
        ProjectDeleted,
        /// <summary>
        /// 
        /// </summary>
        RateLimitUpdated,
        /// <summary>
        /// 
        /// </summary>
        RateLimitDeleted,
        /// <summary>
        /// 
        /// </summary>
        ResourceDeleted,
        /// <summary>
        /// 
        /// </summary>
        TunnelCreated,
        /// <summary>
        /// 
        /// </summary>
        TunnelUpdated,
        /// <summary>
        /// 
        /// </summary>
        TunnelDeleted,
        /// <summary>
        /// 
        /// </summary>
        RoleCreated,
        /// <summary>
        /// 
        /// </summary>
        RoleUpdated,
        /// <summary>
        /// 
        /// </summary>
        RoleDeleted,
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
        ScimEnabled,
        /// <summary>
        /// 
        /// </summary>
        ScimDisabled,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountCreated,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountUpdated,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccountDeleted,
        /// <summary>
        /// 
        /// </summary>
        UserAdded,
        /// <summary>
        /// 
        /// </summary>
        UserUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserDeleted,
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
                AuditLogEventType.ApiKeyUpdated => "api_key.updated",
                AuditLogEventType.ApiKeyDeleted => "api_key.deleted",
                AuditLogEventType.CertificateCreated => "certificate.created",
                AuditLogEventType.CertificateUpdated => "certificate.updated",
                AuditLogEventType.CertificateDeleted => "certificate.deleted",
                AuditLogEventType.CertificatesActivated => "certificates.activated",
                AuditLogEventType.CertificatesDeactivated => "certificates.deactivated",
                AuditLogEventType.CheckpointPermissionCreated => "checkpoint.permission.created",
                AuditLogEventType.CheckpointPermissionDeleted => "checkpoint.permission.deleted",
                AuditLogEventType.ExternalKeyRegistered => "external_key.registered",
                AuditLogEventType.ExternalKeyRemoved => "external_key.removed",
                AuditLogEventType.GroupCreated => "group.created",
                AuditLogEventType.GroupUpdated => "group.updated",
                AuditLogEventType.GroupDeleted => "group.deleted",
                AuditLogEventType.InviteSent => "invite.sent",
                AuditLogEventType.InviteAccepted => "invite.accepted",
                AuditLogEventType.InviteDeleted => "invite.deleted",
                AuditLogEventType.IpAllowlistCreated => "ip_allowlist.created",
                AuditLogEventType.IpAllowlistUpdated => "ip_allowlist.updated",
                AuditLogEventType.IpAllowlistDeleted => "ip_allowlist.deleted",
                AuditLogEventType.IpAllowlistConfigActivated => "ip_allowlist.config.activated",
                AuditLogEventType.IpAllowlistConfigDeactivated => "ip_allowlist.config.deactivated",
                AuditLogEventType.LoginSucceeded => "login.succeeded",
                AuditLogEventType.LoginFailed => "login.failed",
                AuditLogEventType.LogoutSucceeded => "logout.succeeded",
                AuditLogEventType.LogoutFailed => "logout.failed",
                AuditLogEventType.OrganizationUpdated => "organization.updated",
                AuditLogEventType.ProjectCreated => "project.created",
                AuditLogEventType.ProjectUpdated => "project.updated",
                AuditLogEventType.ProjectArchived => "project.archived",
                AuditLogEventType.ProjectDeleted => "project.deleted",
                AuditLogEventType.RateLimitUpdated => "rate_limit.updated",
                AuditLogEventType.RateLimitDeleted => "rate_limit.deleted",
                AuditLogEventType.ResourceDeleted => "resource.deleted",
                AuditLogEventType.TunnelCreated => "tunnel.created",
                AuditLogEventType.TunnelUpdated => "tunnel.updated",
                AuditLogEventType.TunnelDeleted => "tunnel.deleted",
                AuditLogEventType.RoleCreated => "role.created",
                AuditLogEventType.RoleUpdated => "role.updated",
                AuditLogEventType.RoleDeleted => "role.deleted",
                AuditLogEventType.RoleAssignmentCreated => "role.assignment.created",
                AuditLogEventType.RoleAssignmentDeleted => "role.assignment.deleted",
                AuditLogEventType.ScimEnabled => "scim.enabled",
                AuditLogEventType.ScimDisabled => "scim.disabled",
                AuditLogEventType.ServiceAccountCreated => "service_account.created",
                AuditLogEventType.ServiceAccountUpdated => "service_account.updated",
                AuditLogEventType.ServiceAccountDeleted => "service_account.deleted",
                AuditLogEventType.UserAdded => "user.added",
                AuditLogEventType.UserUpdated => "user.updated",
                AuditLogEventType.UserDeleted => "user.deleted",
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
                "api_key.updated" => AuditLogEventType.ApiKeyUpdated,
                "api_key.deleted" => AuditLogEventType.ApiKeyDeleted,
                "certificate.created" => AuditLogEventType.CertificateCreated,
                "certificate.updated" => AuditLogEventType.CertificateUpdated,
                "certificate.deleted" => AuditLogEventType.CertificateDeleted,
                "certificates.activated" => AuditLogEventType.CertificatesActivated,
                "certificates.deactivated" => AuditLogEventType.CertificatesDeactivated,
                "checkpoint.permission.created" => AuditLogEventType.CheckpointPermissionCreated,
                "checkpoint.permission.deleted" => AuditLogEventType.CheckpointPermissionDeleted,
                "external_key.registered" => AuditLogEventType.ExternalKeyRegistered,
                "external_key.removed" => AuditLogEventType.ExternalKeyRemoved,
                "group.created" => AuditLogEventType.GroupCreated,
                "group.updated" => AuditLogEventType.GroupUpdated,
                "group.deleted" => AuditLogEventType.GroupDeleted,
                "invite.sent" => AuditLogEventType.InviteSent,
                "invite.accepted" => AuditLogEventType.InviteAccepted,
                "invite.deleted" => AuditLogEventType.InviteDeleted,
                "ip_allowlist.created" => AuditLogEventType.IpAllowlistCreated,
                "ip_allowlist.updated" => AuditLogEventType.IpAllowlistUpdated,
                "ip_allowlist.deleted" => AuditLogEventType.IpAllowlistDeleted,
                "ip_allowlist.config.activated" => AuditLogEventType.IpAllowlistConfigActivated,
                "ip_allowlist.config.deactivated" => AuditLogEventType.IpAllowlistConfigDeactivated,
                "login.succeeded" => AuditLogEventType.LoginSucceeded,
                "login.failed" => AuditLogEventType.LoginFailed,
                "logout.succeeded" => AuditLogEventType.LogoutSucceeded,
                "logout.failed" => AuditLogEventType.LogoutFailed,
                "organization.updated" => AuditLogEventType.OrganizationUpdated,
                "project.created" => AuditLogEventType.ProjectCreated,
                "project.updated" => AuditLogEventType.ProjectUpdated,
                "project.archived" => AuditLogEventType.ProjectArchived,
                "project.deleted" => AuditLogEventType.ProjectDeleted,
                "rate_limit.updated" => AuditLogEventType.RateLimitUpdated,
                "rate_limit.deleted" => AuditLogEventType.RateLimitDeleted,
                "resource.deleted" => AuditLogEventType.ResourceDeleted,
                "tunnel.created" => AuditLogEventType.TunnelCreated,
                "tunnel.updated" => AuditLogEventType.TunnelUpdated,
                "tunnel.deleted" => AuditLogEventType.TunnelDeleted,
                "role.created" => AuditLogEventType.RoleCreated,
                "role.updated" => AuditLogEventType.RoleUpdated,
                "role.deleted" => AuditLogEventType.RoleDeleted,
                "role.assignment.created" => AuditLogEventType.RoleAssignmentCreated,
                "role.assignment.deleted" => AuditLogEventType.RoleAssignmentDeleted,
                "scim.enabled" => AuditLogEventType.ScimEnabled,
                "scim.disabled" => AuditLogEventType.ScimDisabled,
                "service_account.created" => AuditLogEventType.ServiceAccountCreated,
                "service_account.updated" => AuditLogEventType.ServiceAccountUpdated,
                "service_account.deleted" => AuditLogEventType.ServiceAccountDeleted,
                "user.added" => AuditLogEventType.UserAdded,
                "user.updated" => AuditLogEventType.UserUpdated,
                "user.deleted" => AuditLogEventType.UserDeleted,
                _ => null,
            };
        }
    }
}