
#nullable enable

namespace tryAGI.OpenAI
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AuditLogActorTypeJsonConverter))]
        public global::tryAGI.OpenAI.AuditLogActorType? Type { get; set; }

        /// <summary>
        /// The session in which the audit logged action was performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::tryAGI.OpenAI.AuditLogActorSession? Session { get; set; }

        /// <summary>
        /// The API Key used to perform the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::tryAGI.OpenAI.AuditLogActorApiKey? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActor" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of actor. Is either `session` or `api_key`.
        /// </param>
        /// <param name="session">
        /// The session in which the audit logged action was performed.
        /// </param>
        /// <param name="apiKey">
        /// The API Key used to perform the audit logged action.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogActor(
            global::tryAGI.OpenAI.AuditLogActorType? type,
            global::tryAGI.OpenAI.AuditLogActorSession? session,
            global::tryAGI.OpenAI.AuditLogActorApiKey? apiKey)
        {
            this.Type = type;
            this.Session = session;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActor" /> class.
        /// </summary>
        public AuditLogActor()
        {
        }
    }
}