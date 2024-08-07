
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogApiKey.created
    {
        /// <summary>
        /// The tracking ID of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to create the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::OpenAI.AuditLogApiKey.createdData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}