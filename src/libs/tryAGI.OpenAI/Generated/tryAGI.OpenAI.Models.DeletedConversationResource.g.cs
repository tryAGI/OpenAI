
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeletedConversationResource
    {
        /// <summary>
        /// Default Value: conversation.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedConversationResourceObject.ConversationDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedConversationResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedConversationResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedConversationResourceObject.ConversationDeleted;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="DeletedConversationResource" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: conversation.deleted
        /// </param>
        /// <param name="deleted"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedConversationResource(
            bool deleted,
            string id,
            global::tryAGI.OpenAI.DeletedConversationResourceObject @object = global::tryAGI.OpenAI.DeletedConversationResourceObject.ConversationDeleted)
        {
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedConversationResource" /> class.
        /// </summary>
        public DeletedConversationResource()
        {
        }
    }
}