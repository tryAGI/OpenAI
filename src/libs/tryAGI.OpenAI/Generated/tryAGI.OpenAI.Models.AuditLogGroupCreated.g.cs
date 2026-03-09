
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogGroupCreated
    {
        /// <summary>
        /// The ID of the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Information about the created group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::tryAGI.OpenAI.AuditLogGroupCreatedData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogGroupCreated" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the group.
        /// </param>
        /// <param name="data">
        /// Information about the created group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogGroupCreated(
            string? id,
            global::tryAGI.OpenAI.AuditLogGroupCreatedData? data)
        {
            this.Id = id;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogGroupCreated" /> class.
        /// </summary>
        public AuditLogGroupCreated()
        {
        }
    }
}