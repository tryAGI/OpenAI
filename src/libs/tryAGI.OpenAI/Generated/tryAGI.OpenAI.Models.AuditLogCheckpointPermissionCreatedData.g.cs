
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The payload used to create the checkpoint permission.
    /// </summary>
    public sealed partial class AuditLogCheckpointPermissionCreatedData
    {
        /// <summary>
        /// The ID of the fine-tuned model checkpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model_checkpoint")]
        public string? FineTunedModelCheckpoint { get; set; }

        /// <summary>
        /// The ID of the project that the checkpoint permission was created for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCheckpointPermissionCreatedData" /> class.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// The ID of the fine-tuned model checkpoint.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project that the checkpoint permission was created for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogCheckpointPermissionCreatedData(
            string? fineTunedModelCheckpoint,
            string? projectId)
        {
            this.FineTunedModelCheckpoint = fineTunedModelCheckpoint;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogCheckpointPermissionCreatedData" /> class.
        /// </summary>
        public AuditLogCheckpointPermissionCreatedData()
        {
        }
    }
}