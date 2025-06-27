
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogServiceAccountCreated
    {
        /// <summary>
        /// The payload used to create the service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::tryAGI.OpenAI.AuditLogServiceAccountCreatedData? Data { get; set; }

        /// <summary>
        /// The service account ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogServiceAccountCreated" /> class.
        /// </summary>
        /// <param name="data">
        /// The payload used to create the service account.
        /// </param>
        /// <param name="id">
        /// The service account ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogServiceAccountCreated(
            global::tryAGI.OpenAI.AuditLogServiceAccountCreatedData? data,
            string? id)
        {
            this.Data = data;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogServiceAccountCreated" /> class.
        /// </summary>
        public AuditLogServiceAccountCreated()
        {
        }
    }
}