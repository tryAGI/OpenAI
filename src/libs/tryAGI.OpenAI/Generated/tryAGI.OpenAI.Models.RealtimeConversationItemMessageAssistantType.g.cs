
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `message`.
    /// </summary>
    public enum RealtimeConversationItemMessageAssistantType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageAssistantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageAssistantType value)
        {
            return value switch
            {
                RealtimeConversationItemMessageAssistantType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageAssistantType? ToEnum(string value)
        {
            return value switch
            {
                "message" => RealtimeConversationItemMessageAssistantType.Message,
                _ => null,
            };
        }
    }
}