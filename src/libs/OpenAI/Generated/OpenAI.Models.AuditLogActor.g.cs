
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The actor who performed the audit logged action.
    /// </summary>
    public sealed partial class AuditLogActor
    {
        /// <summary>
        /// The type of actor. Is either `session` or `api_key`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.AuditLogActorTypeJsonConverter))]
        public global::OpenAI.AuditLogActorType? Type { get; set; }

        /// <summary>
        /// The session in which the audit logged action was performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::OpenAI.AuditLogActorSession? Session { get; set; }

        /// <summary>
        /// The API Key used to perform the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::OpenAI.AuditLogActorApiKey? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}