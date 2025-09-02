
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `message`.
    /// </summary>
    public enum RealtimeConversationItemMessageSystemType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageSystemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageSystemType value)
        {
            return value switch
            {
                RealtimeConversationItemMessageSystemType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageSystemType? ToEnum(string value)
        {
            return value switch
            {
                "message" => RealtimeConversationItemMessageSystemType.Message,
                _ => null,
            };
        }
    }
}