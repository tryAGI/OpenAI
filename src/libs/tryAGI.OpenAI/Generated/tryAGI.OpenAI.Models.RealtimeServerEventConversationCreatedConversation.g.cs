
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The conversation resource.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationCreatedConversation
    {
        /// <summary>
        /// The unique ID of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type, must be `realtime.conversation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventConversationCreatedConversationObjectJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversationObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationCreatedConversation" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the conversation.
        /// </param>
        /// <param name="object">
        /// The object type, must be `realtime.conversation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationCreatedConversation(
            string? id,
            global::tryAGI.OpenAI.RealtimeServerEventConversationCreatedConversationObject? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationCreatedConversation" /> class.
        /// </summary>
        public RealtimeServerEventConversationCreatedConversation()
        {
        }
    }
}