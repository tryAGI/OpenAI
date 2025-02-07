
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
        /// The project that the action was scoped to. Absent for actions not scoped to projects.
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
        /// The project that the action was scoped to. Absent for actions not scoped to projects.
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
        /// <param name="inviteSent">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteAccepted">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="inviteDeleted">
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
        /// <param name="projectCreated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="projectArchived">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="rateLimitUpdated">
        /// The details for events with this `type`.
        /// </param>
        /// <param name="rateLimitDeleted">
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
            global::tryAGI.OpenAI.AuditLogInviteSent? inviteSent,
            global::tryAGI.OpenAI.AuditLogInviteAccepted? inviteAccepted,
            global::tryAGI.OpenAI.AuditLogInviteDeleted? inviteDeleted,
            global::tryAGI.OpenAI.AuditLogLoginFailed? loginFailed,
            global::tryAGI.OpenAI.AuditLogLogoutFailed? logoutFailed,
            global::tryAGI.OpenAI.AuditLogOrganizationUpdated? organizationUpdated,
            global::tryAGI.OpenAI.AuditLogProjectCreated? projectCreated,
            global::tryAGI.OpenAI.AuditLogProjectUpdated? projectUpdated,
            global::tryAGI.OpenAI.AuditLogProjectArchived? projectArchived,
            global::tryAGI.OpenAI.AuditLogRateLimitUpdated? rateLimitUpdated,
            global::tryAGI.OpenAI.AuditLogRateLimitDeleted? rateLimitDeleted,
            global::tryAGI.OpenAI.AuditLogServiceAccountCreated? serviceAccountCreated,
            global::tryAGI.OpenAI.AuditLogServiceAccountUpdated? serviceAccountUpdated,
            global::tryAGI.OpenAI.AuditLogServiceAccountDeleted? serviceAccountDeleted,
            global::tryAGI.OpenAI.AuditLogUserAdded? userAdded,
            global::tryAGI.OpenAI.AuditLogUserUpdated? userUpdated,
            global::tryAGI.OpenAI.AuditLogUserDeleted? userDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.EffectiveAt = effectiveAt;
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Project = project;
            this.ApiKeyCreated = apiKeyCreated;
            this.ApiKeyUpdated = apiKeyUpdated;
            this.ApiKeyDeleted = apiKeyDeleted;
            this.InviteSent = inviteSent;
            this.InviteAccepted = inviteAccepted;
            this.InviteDeleted = inviteDeleted;
            this.LoginFailed = loginFailed;
            this.LogoutFailed = logoutFailed;
            this.OrganizationUpdated = organizationUpdated;
            this.ProjectCreated = projectCreated;
            this.ProjectUpdated = projectUpdated;
            this.ProjectArchived = projectArchived;
            this.RateLimitUpdated = rateLimitUpdated;
            this.RateLimitDeleted = rateLimitDeleted;
            this.ServiceAccountCreated = serviceAccountCreated;
            this.ServiceAccountUpdated = serviceAccountUpdated;
            this.ServiceAccountDeleted = serviceAccountDeleted;
            this.UserAdded = userAdded;
            this.UserUpdated = userUpdated;
            this.UserDeleted = userDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLog" /> class.
        /// </summary>
        public AuditLog()
        {
        }
    }
}