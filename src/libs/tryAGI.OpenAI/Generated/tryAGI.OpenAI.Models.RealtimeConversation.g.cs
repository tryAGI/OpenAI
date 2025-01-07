
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A realtime Conversation consists of a list of Items.<br/>
    /// By default, there is only one Conversation, and it gets created at the beginning of the Session.<br/>
    /// In the future, we may add support for additional conversations.
    /// </summary>
    public sealed partial class RealtimeConversation
    {
        /// <summary>
        /// The unique ID of the conversation.<br/>
        /// Example: conv_001
        /// </summary>
        /// <example>conv_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type, must be "realtime.conversation".<br/>
        /// Example: realtime.conversation
        /// </summary>
        /// <example>realtime.conversation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeConversationObjectJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeConversationObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversation" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the conversation.<br/>
        /// Example: conv_001
        /// </param>
        /// <param name="object">
        /// The object type, must be "realtime.conversation".<br/>
        /// Example: realtime.conversation
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeConversation(
            string? id,
            global::tryAGI.OpenAI.RealtimeConversationObject? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversation" /> class.
        /// </summary>
        public RealtimeConversation()
        {
        }
    }
}