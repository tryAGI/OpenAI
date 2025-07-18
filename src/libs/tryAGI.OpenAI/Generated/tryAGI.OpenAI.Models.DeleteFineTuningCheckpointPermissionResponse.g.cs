
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFineTuningCheckpointPermissionResponse
    {
        /// <summary>
        /// Whether the fine-tuned model checkpoint permission was successfully deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The ID of the fine-tuned model checkpoint permission that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always "checkpoint.permission".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeleteFineTuningCheckpointPermissionResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFineTuningCheckpointPermissionResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the fine-tuned model checkpoint permission was successfully deleted.
        /// </param>
        /// <param name="id">
        /// The ID of the fine-tuned model checkpoint permission that was deleted.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "checkpoint.permission".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteFineTuningCheckpointPermissionResponse(
            bool deleted,
            string id,
            global::tryAGI.OpenAI.DeleteFineTuningCheckpointPermissionResponseObject @object)
        {
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFineTuningCheckpointPermissionResponse" /> class.
        /// </summary>
        public DeleteFineTuningCheckpointPermissionResponse()
        {
        }
    }
}