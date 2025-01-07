
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.item.created".<br/>
    /// Example: conversation.item.created
    /// </summary>
    public enum RealtimeConversationItemCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemCreatedType value)
        {
            return value switch
            {
                RealtimeConversationItemCreatedType.ConversationItemCreated => "conversation.item.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.created" => RealtimeConversationItemCreatedType.ConversationItemCreated,
                _ => null,
            };
        }
    }
}