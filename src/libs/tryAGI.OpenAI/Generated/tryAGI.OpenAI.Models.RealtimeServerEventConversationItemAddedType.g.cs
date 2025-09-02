
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.added`.
    /// </summary>
    public enum RealtimeServerEventConversationItemAddedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemAddedType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemAddedType.ConversationItemAdded => "conversation.item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemAddedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.added" => RealtimeServerEventConversationItemAddedType.ConversationItemAdded,
                _ => null,
            };
        }
    }
}