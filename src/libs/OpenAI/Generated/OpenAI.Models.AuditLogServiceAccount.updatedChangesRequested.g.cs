
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The payload used to updated the service account.
    /// </summary>
    public sealed partial class AuditLogServiceAccount.updatedChangesRequested
    {
        /// <summary>
        /// The role of the service account. Is either `owner` or `member`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}