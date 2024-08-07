
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogInvite.deleted
    {
        /// <summary>
        /// The ID of the invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}