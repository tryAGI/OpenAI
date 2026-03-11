
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after deleting a thread.
    /// </summary>
    public sealed partial class DeletedThreadResource
    {
        /// <summary>
        /// Identifier of the deleted thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Type discriminator that is always `chatkit.thread.deleted`.<br/>
        /// Default Value: chatkit.thread.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedThreadResourceObject.ChatkitThreadDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedThreadResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedThreadResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedThreadResourceObject.ChatkitThreadDeleted;

        /// <summary>
        /// Indicates that the thread has been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedThreadResource" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the deleted thread.
        /// </param>
        /// <param name="object">
        /// Type discriminator that is always `chatkit.thread.deleted`.<br/>
        /// Default Value: chatkit.thread.deleted
        /// </param>
        /// <param name="deleted">
        /// Indicates that the thread has been deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedThreadResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.DeletedThreadResourceObject @object = global::tryAGI.OpenAI.DeletedThreadResourceObject.ChatkitThreadDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedThreadResource" /> class.
        /// </summary>
        public DeletedThreadResource()
        {
        }
    }
}