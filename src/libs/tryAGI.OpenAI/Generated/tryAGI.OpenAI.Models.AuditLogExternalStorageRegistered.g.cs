
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogExternalStorageRegistered
    {
        /// <summary>
        /// The ID of the external storage configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The configuration for the external storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::tryAGI.OpenAI.AuditLogExternalStorageRegisteredData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogExternalStorageRegistered" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the external storage configuration.
        /// </param>
        /// <param name="data">
        /// The configuration for the external storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogExternalStorageRegistered(
            string? id,
            global::tryAGI.OpenAI.AuditLogExternalStorageRegisteredData? data)
        {
            this.Id = id;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogExternalStorageRegistered" /> class.
        /// </summary>
        public AuditLogExternalStorageRegistered()
        {
        }

    }
}