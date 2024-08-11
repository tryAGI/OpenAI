
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The payload used to update the project.
    /// </summary>
    public sealed partial class AuditLogProjectUpdatedChangesRequested
    {
        /// <summary>
        /// The title of the project as seen on the dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}