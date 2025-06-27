
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A log of a user action or configuration change within this organization.
    /// </summary>
    public sealed partial class AuditLog
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.deleted")]
        public global::tryAGI.OpenAI.AuditLogApiKeyDeleted? ApiKeyDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.updated")]
        public global::tryAGI.OpenAI.AuditLogApiKeyUpdated? ApiKeyUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate.created")]
        public global::tryAGI.OpenAI.AuditLogCertificateCreated? CertificateCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate.deleted")]
        public global::tryAGI.OpenAI.AuditLogCertificateDeleted? CertificateDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificate.updated")]
        public global::tryAGI.OpenAI.AuditLogCertificateUpdated? CertificateUpdated { get; set; }

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
        /// The project and fine-tuned model checkpoint that the checkpoint permission was created for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_permission.created")]
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated? CheckpointPermissionCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_permission.deleted")]
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted? CheckpointPermissionDeleted { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// The ID of this log.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.sent")]
        public global::tryAGI.OpenAI.AuditLogInviteSent? InviteSent { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login.failed")]
        public global::tryAGI.OpenAI.AuditLogLoginFailed? LoginFailed { get; set; }

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
        /// The project that the action was scoped to. Absent for actions not scoped to projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::tryAGI.OpenAI.AuditLogProject? Project { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.archived")]
        public global::tryAGI.OpenAI.AuditLogProjectArchived? ProjectArchived { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit.deleted")]
        public global::tryAGI.OpenAI.AuditLogRateLimitDeleted? RateLimitDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit.updated")]
        public global::tryAGI.OpenAI.AuditLogRateLimitUpdated? RateLimitUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.created")]
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreated? ServiceAccountCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.deleted")]
        public global::tryAGI.OpenAI.AuditLogServiceAccountDeleted? ServiceAccountDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.updated")]
        public global::tryAGI.OpenAI.AuditLogServiceAccountUpdated? ServiceAccountUpdated { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AuditLogEventType Type { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.added")]
        public global::tryAGI.OpenAI.AuditLogUserAdded? UserAdded { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.deleted")]
        public global::tryAGI.OpenAI.AuditLogUserDeleted? UserDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.updated")]
        public global::tryAGI.OpenAI.AuditLogUserUpdated? UserUpdated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLog" /> class.
        /// </summary>
        /// <param name="actor">
        /// The actor who performed the audit logged action.
        /// </param>
        /// <param name="apiKeyCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="apiKeyDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="apiKeyUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificateCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificateDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificateUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificatesActivated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="certificatesDeactivated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="checkpointPermissionCreated">
        /// The project and fine-tuned model checkpoint that the checkpoint permission was created for.
        /// </param>
        /// <param name="checkpointPermissionDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="effectiveAt">
        /// The Unix timestamp (in seconds) of the event.
        /// </param>
        /// <param name="id">
        /// The ID of this log.
        /// </param>
        /// <param name="inviteAccepted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteSent">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="loginFailed">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="logoutFailed">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="organizationUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="project">
        /// The project that the action was scoped to. Absent for actions not scoped to projects.
        /// </param>
        /// <param name="projectArchived">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="rateLimitDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="rateLimitUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="serviceAccountUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="userAdded">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="userDeleted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="userUpdated">
        /// The details for events with this `type`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLog(
            global::tryAGI.OpenAI.AuditLogActor actor,
            global::System.DateTimeOffset effectiveAt,
            string id,
            global::tryAGI.OpenAI.AuditLogEventType type,
            global::tryAGI.OpenAI.AuditLogApiKeyCreated? apiKeyCreated,
            global::tryAGI.OpenAI.AuditLogApiKeyDeleted? apiKeyDeleted,
            global::tryAGI.OpenAI.AuditLogApiKeyUpdated? apiKeyUpdated,
            global::tryAGI.OpenAI.AuditLogCertificateCreated? certificateCreated,
            global::tryAGI.OpenAI.AuditLogCertificateDeleted? certificateDeleted,
            global::tryAGI.OpenAI.AuditLogCertificateUpdated? certificateUpdated,
            global::tryAGI.OpenAI.AuditLogCertificatesActivated? certificatesActivated,
            global::tryAGI.OpenAI.AuditLogCertificatesDeactivated? certificatesDeactivated,
            global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreated? checkpointPermissionCreated,
            global::tryAGI.OpenAI.AuditLogCheckpointPermissionDeleted? checkpointPermissionDeleted,
            global::tryAGI.OpenAI.AuditLogInviteAccepted? inviteAccepted,
            global::tryAGI.OpenAI.AuditLogInviteDeleted? inviteDeleted,
            global::tryAGI.OpenAI.AuditLogInviteSent? inviteSent,
            global::tryAGI.OpenAI.AuditLogLoginFailed? loginFailed,
            global::tryAGI.OpenAI.AuditLogLogoutFailed? logoutFailed,
            global::tryAGI.OpenAI.AuditLogOrganizationUpdated? organizationUpdated,
            global::tryAGI.OpenAI.AuditLogProject? project,
            global::tryAGI.OpenAI.AuditLogProjectArchived? projectArchived,
            global::tryAGI.OpenAI.AuditLogProjectCreated? projectCreated,
            global::tryAGI.OpenAI.AuditLogProjectUpdated? projectUpdated,
            global::tryAGI.OpenAI.AuditLogRateLimitDeleted? rateLimitDeleted,
            global::tryAGI.OpenAI.AuditLogRateLimitUpdated? rateLimitUpdated,
            global::tryAGI.OpenAI.AuditLogServiceAccountCreated? serviceAccountCreated,
            global::tryAGI.OpenAI.AuditLogServiceAccountDeleted? serviceAccountDeleted,
            global::tryAGI.OpenAI.AuditLogServiceAccountUpdated? serviceAccountUpdated,
            global::tryAGI.OpenAI.AuditLogUserAdded? userAdded,
            global::tryAGI.OpenAI.AuditLogUserDeleted? userDeleted,
            global::tryAGI.OpenAI.AuditLogUserUpdated? userUpdated)
        {
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.EffectiveAt = effectiveAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ApiKeyCreated = apiKeyCreated;
            this.ApiKeyDeleted = apiKeyDeleted;
            this.ApiKeyUpdated = apiKeyUpdated;
            this.CertificateCreated = certificateCreated;
            this.CertificateDeleted = certificateDeleted;
            this.CertificateUpdated = certificateUpdated;
            this.CertificatesActivated = certificatesActivated;
            this.CertificatesDeactivated = certificatesDeactivated;
            this.CheckpointPermissionCreated = checkpointPermissionCreated;
            this.CheckpointPermissionDeleted = checkpointPermissionDeleted;
            this.InviteAccepted = inviteAccepted;
            this.InviteDeleted = inviteDeleted;
            this.InviteSent = inviteSent;
            this.LoginFailed = loginFailed;
            this.LogoutFailed = logoutFailed;
            this.OrganizationUpdated = organizationUpdated;
            this.Project = project;
            this.ProjectArchived = projectArchived;
            this.ProjectCreated = projectCreated;
            this.ProjectUpdated = projectUpdated;
            this.RateLimitDeleted = rateLimitDeleted;
            this.RateLimitUpdated = rateLimitUpdated;
            this.ServiceAccountCreated = serviceAccountCreated;
            this.ServiceAccountDeleted = serviceAccountDeleted;
            this.ServiceAccountUpdated = serviceAccountUpdated;
            this.UserAdded = userAdded;
            this.UserDeleted = userDeleted;
            this.UserUpdated = userUpdated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLog" /> class.
        /// </summary>
        public AuditLog()
        {
        }
    }
}