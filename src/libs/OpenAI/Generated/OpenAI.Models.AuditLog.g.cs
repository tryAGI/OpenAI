
#nullable enable

namespace OpenAI
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AuditLogEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.AuditLogEventType Type { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EffectiveAt { get; set; }

        /// <summary>
        /// The project that the action was scoped to. Absent for actions not scoped to projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::OpenAI.AuditLogProject? Project { get; set; }

        /// <summary>
        /// The actor who performed the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.AuditLogActor Actor { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.created")]
        public global::OpenAI.AuditLogApiKeyCreated? ApiKeyCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.updated")]
        public global::OpenAI.AuditLogApiKeyUpdated? ApiKeyUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.deleted")]
        public global::OpenAI.AuditLogApiKeyDeleted? ApiKeyDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.sent")]
        public global::OpenAI.AuditLogInviteSent? InviteSent { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.accepted")]
        public global::OpenAI.AuditLogInviteAccepted? InviteAccepted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.deleted")]
        public global::OpenAI.AuditLogInviteDeleted? InviteDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login.failed")]
        public global::OpenAI.AuditLogLoginFailed? LoginFailed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logout.failed")]
        public global::OpenAI.AuditLogLogoutFailed? LogoutFailed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization.updated")]
        public global::OpenAI.AuditLogOrganizationUpdated? OrganizationUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.created")]
        public global::OpenAI.AuditLogProjectCreated? ProjectCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.updated")]
        public global::OpenAI.AuditLogProjectUpdated? ProjectUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.archived")]
        public global::OpenAI.AuditLogProjectArchived? ProjectArchived { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.created")]
        public global::OpenAI.AuditLogServiceAccountCreated? ServiceAccountCreated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.updated")]
        public global::OpenAI.AuditLogServiceAccountUpdated? ServiceAccountUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.deleted")]
        public global::OpenAI.AuditLogServiceAccountDeleted? ServiceAccountDeleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.added")]
        public global::OpenAI.AuditLogUserAdded? UserAdded { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.updated")]
        public global::OpenAI.AuditLogUserUpdated? UserUpdated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.deleted")]
        public global::OpenAI.AuditLogUserDeleted? UserDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}