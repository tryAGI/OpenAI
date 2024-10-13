
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.item.deleted".<br/>
    /// Example: conversation.item.deleted
    /// </summary>
    public enum RealtimeConversationItemDeletedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemDeletedType value)
        {
            return value switch
            {
                RealtimeConversationItemDeletedType.ConversationItemDeleted => "conversation.item.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.deleted" => RealtimeConversationItemDeletedType.ConversationItemDeleted,
                _ => null,
            };
        }
    }
}