
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Information about the created group.
    /// </summary>
    public sealed partial class AuditLogGroupCreatedData
    {
        /// <summary>
        /// The group name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogGroupCreatedData" /> class.
        /// </summary>
        /// <param name="groupName">
        /// The group name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogGroupCreatedData(
            string? groupName)
        {
            this.GroupName = groupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogGroupCreatedData" /> class.
        /// </summary>
        public AuditLogGroupCreatedData()
        {
        }
    }
}