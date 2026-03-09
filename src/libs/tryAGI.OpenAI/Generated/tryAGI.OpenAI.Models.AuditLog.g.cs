
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A log of a user action or configuration change within this organization.
    /// </summary>
    public sealed partial class AuditLog
    {
        /// <summary>
        /// The ID of this log.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AuditLogEventType Type { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// The project that the action was scoped to. Absent for actions not scoped to projects. Note that any admin actions taken via Admin API keys are associated with the default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::tryAGI.OpenAI.AuditLogProject? Project { get; set; }

        /// <summary>
        /// The actor who performed the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AuditLogActor Actor { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.created")]
        public global::tryAGI.OpenAI.AuditLogApiKeyCreated? ApiKeyCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.updated")]
        public global::tryAGI.OpenAI.AuditLogApiKeyUpdated? ApiKeyUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.deleted")]
        public global::tryAGI.OpenAI.AuditLogApiKeyDeleted? ApiKeyDeleted { get; set; }

        /// <summary>
        /// The project and fine-tuned model checkpoint that the checkpoint permission was created for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint.permission.created")]
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated? CheckpointPermissionCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint.permission.deleted")]
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted? CheckpointPermissionDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key.registered")]
        public global::tryAGI.OpenAI.AuditLogExternalKeyRegistered? ExternalKeyRegistered { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key.removed")]
        public global::tryAGI.OpenAI.AuditLogExternalKeyRemoved? ExternalKeyRemoved { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group.created")]
        public global::tryAGI.OpenAI.AuditLogGroupCreated? GroupCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group.updated")]
        public global::tryAGI.OpenAI.AuditLogGroupUpdated? GroupUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group.deleted")]
        public global::tryAGI.OpenAI.AuditLogGroupDeleted? GroupDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim.enabled")]
        public global::tryAGI.OpenAI.AuditLogScimEnabled? ScimEnabled { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim.disabled")]
        public global::tryAGI.OpenAI.AuditLogScimDisabled? ScimDisabled { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.sent")]
        public global::tryAGI.OpenAI.AuditLogInviteSent? InviteSent { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.accepted")]
        public global::tryAGI.OpenAI.AuditLogInviteAccepted? InviteAccepted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.deleted")]
        public global::tryAGI.OpenAI.AuditLogInviteDeleted? InviteDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist.created")]
        public global::tryAGI.OpenAI.AuditLogIpAllowlistCreated? IpAllowlistCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist.updated")]
        public global::tryAGI.OpenAI.AuditLogIpAllowlistUpdated? IpAllowlistUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist.deleted")]
        public global::tryAGI.OpenAI.AuditLogIpAllowlistDeleted? IpAllowlistDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist.config.activated")]
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivated? IpAllowlistConfigActivated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist.config.deactivated")]
        public global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivated? IpAllowlistConfigDeactivated { get; set; }

        /// <summary>
        /// This event has no additional fields beyond the standard audit log attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login.succeeded")]
        public object? LoginSucceeded { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login.failed")]
        public global::tryAGI.OpenAI.AuditLogLoginFailed? LoginFailed { get; set; }

        /// <summary>
        /// This event has no additional fields beyond the standard audit log attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logout.succeeded")]
        public object? LogoutSucceeded { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logout.failed")]
        public global::tryAGI.OpenAI.AuditLogLogoutFailed? LogoutFailed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization.updated")]
        public global::tryAGI.OpenAI.AuditLogOrganizationUpdated? OrganizationUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.created")]
        public global::tryAGI.OpenAI.AuditLogProjectCreated? ProjectCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.updated")]
        public global::tryAGI.OpenAI.AuditLogProjectUpdated? ProjectUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.archived")]
        public global::tryAGI.OpenAI.AuditLogProjectArchived? ProjectArchived { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.deleted")]
        public global::tryAGI.OpenAI.AuditLogProjectDeleted? ProjectDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit.updated")]
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdated? RateLimitUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit.deleted")]
        public global::tryAGI.OpenAI.AuditLogRateLimitDeleted? RateLimitDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role.created")]
        public global::tryAGI.OpenAI.AuditLogRoleCreated? RoleCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role.updated")]
        public global::tryAGI.OpenAI.AuditLogRoleUpdated? RoleUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role.deleted")]
        public global::tryAGI.OpenAI.AuditLogRoleDeleted? RoleDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role.assignment.created")]
        public global::tryAGI.OpenAI.AuditLogRoleAssignmentCreated? RoleAssignmentCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role.assignment.deleted")]
        public global::tryAGI.OpenAI.AuditLogRoleAssignmentDeleted? RoleAssignmentDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.created")]
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreated? ServiceAccountCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.updated")]
        public global::tryAGI.OpenAI.AuditLogServiceAccountUpdated? ServiceAccountUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.deleted")]
        public global::tryAGI.OpenAI.AuditLogServiceAccountDeleted? ServiceAccountDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.added")]
        public global::tryAGI.OpenAI.AuditLogUserAdded? UserAdded { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.updated")]
        public global::tryAGI.OpenAI.AuditLogUserUpdated? UserUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.deleted")]
        public global::tryAGI.OpenAI.AuditLogUserDeleted? UserDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate.created")]
        public global::tryAGI.OpenAI.AuditLogCertificateCreated? CertificateCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate.updated")]
        public global::tryAGI.OpenAI.AuditLogCertificateUpdated? CertificateUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate.deleted")]
        public global::tryAGI.OpenAI.AuditLogCertificateDeleted? CertificateDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificates.activated")]
        public global::tryAGI.OpenAI.AuditLogCertificatesActivated? CertificatesActivated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificates.deactivated")]
        public global::tryAGI.OpenAI.AuditLogCertificatesDeactivated? CertificatesDeactivated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLog" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of this log.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="effectiveAt">
        /// The Unix timestamp (in seconds) of the event.
        /// </param>
        /// <param name="project">
        /// The project that the action was scoped to. Absent for actions not scoped to projects. Note that any admin actions taken via Admin API keys are associated with the default project.
        /// </param>
        /// <param name="actor">
        /// The actor who performed the audit logged action.
        /// </param>
        /// <param name="apiKeyCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="apiKeyUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="apiKeyDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="checkpointPermissionCreated">
        /// The project and fine-tuned model checkpoint that the checkpoint permission was created for.
        /// </param>
        /// <param name="checkpointPermissionDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="externalKeyRegistered">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="externalKeyRemoved">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="groupCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="groupUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="groupDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="scimEnabled">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="scimDisabled">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteSent">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteAccepted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="ipAllowlistCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="ipAllowlistUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="ipAllowlistDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="ipAllowlistConfigActivated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="ipAllowlistConfigDeactivated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="loginSucceeded">
        /// This event has no additional fields beyond the standard audit log attributes.
        /// </param>
        /// <param name="loginFailed">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="logoutSucceeded">
        /// This event has no additional fields beyond the standard audit log attributes.
        /// </param>
        /// <param name="logoutFailed">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="organizationUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectArchived">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="rateLimitUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="rateLimitDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="roleCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="roleUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="roleDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="roleAssignmentCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="roleAssignmentDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="userAdded">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="userUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="userDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificateCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificateUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificateDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificatesActivated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificatesDeactivated">
        /// The details for events with this `type`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLog(
            string id,
            global::tryAGI.OpenAI.AuditLogEventType type,
            global::System.DateTimeOffset effectiveAt,
            global::tryAGI.OpenAI.AuditLogActor actor,
            global::tryAGI.OpenAI.AuditLogProject? project,
            global::tryAGI.OpenAI.AuditLogApiKeyCreated? apiKeyCreated,
            global::tryAGI.OpenAI.AuditLogApiKeyUpdated? apiKeyUpdated,
            global::tryAGI.OpenAI.AuditLogApiKeyDeleted? apiKeyDeleted,
            global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated? checkpointPermissionCreated,
            global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted? checkpointPermissionDeleted,
            global::tryAGI.OpenAI.AuditLogExternalKeyRegistered? externalKeyRegistered,
            global::tryAGI.OpenAI.AuditLogExternalKeyRemoved? externalKeyRemoved,
            global::tryAGI.OpenAI.AuditLogGroupCreated? groupCreated,
            global::tryAGI.OpenAI.AuditLogGroupUpdated? groupUpdated,
            global::tryAGI.OpenAI.AuditLogGroupDeleted? groupDeleted,
            global::tryAGI.OpenAI.AuditLogScimEnabled? scimEnabled,
            global::tryAGI.OpenAI.AuditLogScimDisabled? scimDisabled,
            global::tryAGI.OpenAI.AuditLogInviteSent? inviteSent,
            global::tryAGI.OpenAI.AuditLogInviteAccepted? inviteAccepted,
            global::tryAGI.OpenAI.AuditLogInviteDeleted? inviteDeleted,
            global::tryAGI.OpenAI.AuditLogIpAllowlistCreated? ipAllowlistCreated,
            global::tryAGI.OpenAI.AuditLogIpAllowlistUpdated? ipAllowlistUpdated,
            global::tryAGI.OpenAI.AuditLogIpAllowlistDeleted? ipAllowlistDeleted,
            global::tryAGI.OpenAI.AuditLogIpAllowlistConfigActivated? ipAllowlistConfigActivated,
            global::tryAGI.OpenAI.AuditLogIpAllowlistConfigDeactivated? ipAllowlistConfigDeactivated,
            object? loginSucceeded,
            global::tryAGI.OpenAI.AuditLogLoginFailed? loginFailed,
            object? logoutSucceeded,
            global::tryAGI.OpenAI.AuditLogLogoutFailed? logoutFailed,
            global::tryAGI.OpenAI.AuditLogOrganizationUpdated? organizationUpdated,
            global::tryAGI.OpenAI.AuditLogProjectCreated? projectCreated,
            global::tryAGI.OpenAI.AuditLogProjectUpdated? projectUpdated,
            global::tryAGI.OpenAI.AuditLogProjectArchived? projectArchived,
            global::tryAGI.OpenAI.AuditLogProjectDeleted? projectDeleted,
            global::tryAGI.OpenAI.AuditLogRateLimitUpdated? rateLimitUpdated,
            global::tryAGI.OpenAI.AuditLogRateLimitDeleted? rateLimitDeleted,
            global::tryAGI.OpenAI.AuditLogRoleCreated? roleCreated,
            global::tryAGI.OpenAI.AuditLogRoleUpdated? roleUpdated,
            global::tryAGI.OpenAI.AuditLogRoleDeleted? roleDeleted,
            global::tryAGI.OpenAI.AuditLogRoleAssignmentCreated? roleAssignmentCreated,
            global::tryAGI.OpenAI.AuditLogRoleAssignmentDeleted? roleAssignmentDeleted,
            global::tryAGI.OpenAI.AuditLogServiceAccountCreated? serviceAccountCreated,
            global::tryAGI.OpenAI.AuditLogServiceAccountUpdated? serviceAccountUpdated,
            global::tryAGI.OpenAI.AuditLogServiceAccountDeleted? serviceAccountDeleted,
            global::tryAGI.OpenAI.AuditLogUserAdded? userAdded,
            global::tryAGI.OpenAI.AuditLogUserUpdated? userUpdated,
            global::tryAGI.OpenAI.AuditLogUserDeleted? userDeleted,
            global::tryAGI.OpenAI.AuditLogCertificateCreated? certificateCreated,
            global::tryAGI.OpenAI.AuditLogCertificateUpdated? certificateUpdated,
            global::tryAGI.OpenAI.AuditLogCertificateDeleted? certificateDeleted,
            global::tryAGI.OpenAI.AuditLogCertificatesActivated? certificatesActivated,
            global::tryAGI.OpenAI.AuditLogCertificatesDeactivated? certificatesDeactivated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.EffectiveAt = effectiveAt;
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Project = project;
            this.ApiKeyCreated = apiKeyCreated;
            this.ApiKeyUpdated = apiKeyUpdated;
            this.ApiKeyDeleted = apiKeyDeleted;
            this.CheckpointPermissionCreated = checkpointPermissionCreated;
            this.CheckpointPermissionDeleted = checkpointPermissionDeleted;
            this.ExternalKeyRegistered = externalKeyRegistered;
            this.ExternalKeyRemoved = externalKeyRemoved;
            this.GroupCreated = groupCreated;
            this.GroupUpdated = groupUpdated;
            this.GroupDeleted = groupDeleted;
            this.ScimEnabled = scimEnabled;
            this.ScimDisabled = scimDisabled;
            this.InviteSent = inviteSent;
            this.InviteAccepted = inviteAccepted;
            this.InviteDeleted = inviteDeleted;
            this.IpAllowlistCreated = ipAllowlistCreated;
            this.IpAllowlistUpdated = ipAllowlistUpdated;
            this.IpAllowlistDeleted = ipAllowlistDeleted;
            this.IpAllowlistConfigActivated = ipAllowlistConfigActivated;
            this.IpAllowlistConfigDeactivated = ipAllowlistConfigDeactivated;
            this.LoginSucceeded = loginSucceeded;
            this.LoginFailed = loginFailed;
            this.LogoutSucceeded = logoutSucceeded;
            this.LogoutFailed = logoutFailed;
            this.OrganizationUpdated = organizationUpdated;
            this.ProjectCreated = projectCreated;
            this.ProjectUpdated = projectUpdated;
            this.ProjectArchived = projectArchived;
            this.ProjectDeleted = projectDeleted;
            this.RateLimitUpdated = rateLimitUpdated;
            this.RateLimitDeleted = rateLimitDeleted;
            this.RoleCreated = roleCreated;
            this.RoleUpdated = roleUpdated;
            this.RoleDeleted = roleDeleted;
            this.RoleAssignmentCreated = roleAssignmentCreated;
            this.RoleAssignmentDeleted = roleAssignmentDeleted;
            this.ServiceAccountCreated = serviceAccountCreated;
            this.ServiceAccountUpdated = serviceAccountUpdated;
            this.ServiceAccountDeleted = serviceAccountDeleted;
            this.UserAdded = userAdded;
            this.UserUpdated = userUpdated;
            this.UserDeleted = userDeleted;
            this.CertificateCreated = certificateCreated;
            this.CertificateUpdated = certificateUpdated;
            this.CertificateDeleted = certificateDeleted;
            this.CertificatesActivated = certificatesActivated;
            this.CertificatesDeactivated = certificatesDeactivated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLog" /> class.
        /// </summary>
        public AuditLog()
        {
        }
    }
}