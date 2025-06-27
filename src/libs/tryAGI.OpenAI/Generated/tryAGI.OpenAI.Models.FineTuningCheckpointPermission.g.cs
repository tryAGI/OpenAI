
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The `checkpoint.permission` object represents a permission for a fine-tuned model checkpoint.
    /// </summary>
    public sealed partial class FineTuningCheckpointPermission
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the permission was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The permission identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always "checkpoint.permission".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.FineTuningCheckpointPermissionObjectJsonConverter))]
        public global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject Object { get; set; }

        /// <summary>
        /// The project identifier that the permission is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningCheckpointPermission" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the permission was created.
        /// </param>
        /// <param name="id">
        /// The permission identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "checkpoint.permission".
        /// </param>
        /// <param name="projectId">
        /// The project identifier that the permission is for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningCheckpointPermission(
            global::System.DateTimeOffset createdAt,
            string id,
            string projectId,
            global::tryAGI.OpenAI.FineTuningCheckpointPermissionObject @object)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningCheckpointPermission" /> class.
        /// </summary>
        public FineTuningCheckpointPermission()
        {
        }
    }
}