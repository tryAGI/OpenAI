
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.item.create".<br/>
    /// Example: conversation.item.create
    /// </summary>
    public enum RealtimeConversationItemCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemCreateType value)
        {
            return value switch
            {
                RealtimeConversationItemCreateType.ConversationItemCreate => "conversation.item.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemCreateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.create" => RealtimeConversationItemCreateType.ConversationItemCreate,
                _ => null,
            };
        }
    }
}