
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.item.truncate".<br/>
    /// Example: conversation.item.truncate
    /// </summary>
    public enum RealtimeConversationItemTruncateType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemTruncateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemTruncateType value)
        {
            return value switch
            {
                RealtimeConversationItemTruncateType.ConversationItemTruncate => "conversation.item.truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemTruncateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncate" => RealtimeConversationItemTruncateType.ConversationItemTruncate,
                _ => null,
            };
        }
    }
}