
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The project and fine-tuned model checkpoint that the checkpoint permission was created for.
    /// </summary>
    public sealed partial class AuditLogCheckpointPermissionCreated
    {
        /// <summary>
        /// The payload used to create the checkpoint permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreatedData? Data { get; set; }

        /// <summary>
        /// The ID of the checkpoint permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCheckpointPermissionCreated" /> class.
        /// </summary>
        /// <param name="data">
        /// The payload used to create the checkpoint permission.
        /// </param>
        /// <param name="id">
        /// The ID of the checkpoint permission.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogCheckpointPermissionCreated(
            global::tryAGI.OpenAI.AuditLogCheckpointPermissionCreatedData? data,
            string? id)
        {
            this.Data = data;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCheckpointPermissionCreated" /> class.
        /// </summary>
        public AuditLogCheckpointPermissionCreated()
        {
        }
    }
}