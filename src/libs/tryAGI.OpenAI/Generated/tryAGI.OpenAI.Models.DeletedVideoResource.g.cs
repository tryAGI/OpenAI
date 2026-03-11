
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after deleting a video.
    /// </summary>
    public sealed partial class DeletedVideoResource
    {
        /// <summary>
        /// The object type that signals the deletion response.<br/>
        /// Default Value: video.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedVideoResourceObject.VideoDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedVideoResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedVideoResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedVideoResourceObject.VideoDeleted;

        /// <summary>
        /// Indicates that the video resource was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Identifier of the deleted video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedVideoResource" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type that signals the deletion response.<br/>
        /// Default Value: video.deleted
        /// </param>
        /// <param name="deleted">
        /// Indicates that the video resource was deleted.
        /// </param>
        /// <param name="id">
        /// Identifier of the deleted video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedVideoResource(
            bool deleted,
            string id,
            global::tryAGI.OpenAI.DeletedVideoResourceObject @object = global::tryAGI.OpenAI.DeletedVideoResourceObject.VideoDeleted)
        {
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedVideoResource" /> class.
        /// </summary>
        public DeletedVideoResource()
        {
        }
    }
}