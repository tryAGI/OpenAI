
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteFineTuningCheckpointPermissionResponse
    {
        /// <summary>
        /// The ID of the fine-tuned model checkpoint permission that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always "checkpoint.permission".
        /// </summary>
        /// <default>"checkpoint.permission"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "checkpoint.permission";

        /// <summary>
        /// Whether the fine-tuned model checkpoint permission was successfully deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFineTuningCheckpointPermissionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the fine-tuned model checkpoint permission that was deleted.
        /// </param>
        /// <param name="deleted">
        /// Whether the fine-tuned model checkpoint permission was successfully deleted.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "checkpoint.permission".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteFineTuningCheckpointPermissionResponse(
            string id,
            bool deleted,
            string @object = "checkpoint.permission")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFineTuningCheckpointPermissionResponse" /> class.
        /// </summary>
        public DeleteFineTuningCheckpointPermissionResponse()
        {
        }

    }
}