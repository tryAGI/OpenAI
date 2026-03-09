
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The payload used to update the group.
    /// </summary>
    public sealed partial class AuditLogGroupUpdatedChangesRequested
    {
        /// <summary>
        /// The updated group name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogGroupUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="groupName">
        /// The updated group name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogGroupUpdatedChangesRequested(
            string? groupName)
        {
            this.GroupName = groupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogGroupUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogGroupUpdatedChangesRequested()
        {
        }
    }
}