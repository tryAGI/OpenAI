
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
        public global::OpenAI.AuditLogApiKey.created? ApiKey_created { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.updated")]
        public global::OpenAI.AuditLogApiKey.updated? ApiKey_updated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key.deleted")]
        public global::OpenAI.AuditLogApiKey.deleted? ApiKey_deleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.sent")]
        public global::OpenAI.AuditLogInvite.sent? Invite_sent { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.accepted")]
        public global::OpenAI.AuditLogInvite.accepted? Invite_accepted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite.deleted")]
        public global::OpenAI.AuditLogInvite.deleted? Invite_deleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login.failed")]
        public global::OpenAI.AuditLogLogin.failed? Login_failed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logout.failed")]
        public global::OpenAI.AuditLogLogout.failed? Logout_failed { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization.updated")]
        public global::OpenAI.AuditLogOrganization.updated? Organization_updated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.created")]
        public global::OpenAI.AuditLogProject.created? Project_created { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.updated")]
        public global::OpenAI.AuditLogProject.updated? Project_updated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project.archived")]
        public global::OpenAI.AuditLogProject.archived? Project_archived { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.created")]
        public global::OpenAI.AuditLogServiceAccount.created? ServiceAccount_created { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.updated")]
        public global::OpenAI.AuditLogServiceAccount.updated? ServiceAccount_updated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account.deleted")]
        public global::OpenAI.AuditLogServiceAccount.deleted? ServiceAccount_deleted { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.added")]
        public global::OpenAI.AuditLogUser.added? User_added { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.updated")]
        public global::OpenAI.AuditLogUser.updated? User_updated { get; set; }

        /// <summary>
        /// The details for events with this `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user.deleted")]
        public global::OpenAI.AuditLogUser.deleted? User_deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}