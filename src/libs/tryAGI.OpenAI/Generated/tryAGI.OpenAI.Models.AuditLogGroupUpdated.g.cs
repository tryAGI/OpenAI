
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogGroupUpdated
    {
        /// <summary>
        /// The ID of the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to update the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes_requested")]
        public global::tryAGI.OpenAI.AuditLogGroupUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogGroupUpdated" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the group.
        /// </param>
        /// <param name="changesRequested">
        /// The payload used to update the group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogGroupUpdated(
            string? id,
            global::tryAGI.OpenAI.AuditLogGroupUpdatedChangesRequested? changesRequested)
        {
            this.Id = id;
            this.ChangesRequested = changesRequested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogGroupUpdated" /> class.
        /// </summary>
        public AuditLogGroupUpdated()
        {
        }
    }
}