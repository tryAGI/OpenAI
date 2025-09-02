
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.done`.
    /// </summary>
    public enum RealtimeServerEventConversationItemDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemDoneType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemDoneType.ConversationItemDone => "conversation.item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemDoneType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.done" => RealtimeServerEventConversationItemDoneType.ConversationItemDone,
                _ => null,
            };
        }
    }
}