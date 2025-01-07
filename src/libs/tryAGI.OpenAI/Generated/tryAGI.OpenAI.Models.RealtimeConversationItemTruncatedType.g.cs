
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.item.truncated".<br/>
    /// Example: conversation.item.truncated
    /// </summary>
    public enum RealtimeConversationItemTruncatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemTruncatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemTruncatedType value)
        {
            return value switch
            {
                RealtimeConversationItemTruncatedType.ConversationItemTruncated => "conversation.item.truncated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemTruncatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncated" => RealtimeConversationItemTruncatedType.ConversationItemTruncated,
                _ => null,
            };
        }
    }
}