
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationResource
    {
        /// <summary>
        /// The time at which the conversation was created, measured in seconds since the Unix epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The unique ID of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be         useful for storing additional information about the object in a structured         format, and querying for objects via API or the dashboard.<br/>
        ///         Keys are strings with a maximum length of 64 characters. Values are strings         with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// The object type, which is always `conversation`.<br/>
        /// Default Value: conversation
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ConversationResourceObject.Conversation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ConversationResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ConversationResourceObject Object { get; set; } = global::tryAGI.OpenAI.ConversationResourceObject.Conversation;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResource" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time at which the conversation was created, measured in seconds since the Unix epoch.
        /// </param>
        /// <param name="id">
        /// The unique ID of the conversation.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be         useful for storing additional information about the object in a structured         format, and querying for objects via API or the dashboard.<br/>
        ///         Keys are strings with a maximum length of 64 characters. Values are strings         with a maximum length of 512 characters.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `conversation`.<br/>
        /// Default Value: conversation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationResource(
            int createdAt,
            string id,
            object metadata,
            global::tryAGI.OpenAI.ConversationResourceObject @object = global::tryAGI.OpenAI.ConversationResourceObject.Conversation)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResource" /> class.
        /// </summary>
        public ConversationResource()
        {
        }
    }
}