
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a conversation is created. Emitted right after session creation.
    /// </summary>
    public sealed partial class RealtimeConversationCreated
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_9101
        /// </summary>
        /// <example>event_9101</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "conversation.created".<br/>
        /// Example: conversation.created
        /// </summary>
        /// <example>conversation.created</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationCreatedType? Type { get; set; }

        /// <summary>
        /// A realtime Conversation consists of a list of Items.<br/>
        /// By default, there is only one Conversation, and it gets created at the beginning of the Session.<br/>
        /// In the future, we may add support for additional conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::tryAGI.OpenAI.RealtimeConversation? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_9101
        /// </param>
        /// <param name="type">
        /// The event type, must be "conversation.created".<br/>
        /// Example: conversation.created
        /// </param>
        /// <param name="conversation">
        /// A realtime Conversation consists of a list of Items.<br/>
        /// By default, there is only one Conversation, and it gets created at the beginning of the Session.<br/>
        /// In the future, we may add support for additional conversations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationCreated(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeConversationCreatedType? type,
            global::tryAGI.OpenAI.RealtimeConversation? conversation)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Conversation = conversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationCreated" /> class.
        /// </summary>
        public RealtimeConversationCreated()
        {
        }
    }
}