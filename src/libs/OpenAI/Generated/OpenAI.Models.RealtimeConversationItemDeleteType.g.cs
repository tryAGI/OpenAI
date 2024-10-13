
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.item.delete".<br/>
    /// Example: conversation.item.delete
    /// </summary>
    public enum RealtimeConversationItemDeleteType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDelete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemDeleteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemDeleteType value)
        {
            return value switch
            {
                RealtimeConversationItemDeleteType.ConversationItemDelete => "conversation.item.delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemDeleteType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.delete" => RealtimeConversationItemDeleteType.ConversationItemDelete,
                _ => null,
            };
        }
    }
}