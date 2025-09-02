
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type. Always `text` for assistant messages.
    /// </summary>
    public enum RealtimeConversationItemMessageAssistantContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageAssistantContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageAssistantContentItemType value)
        {
            return value switch
            {
                RealtimeConversationItemMessageAssistantContentItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageAssistantContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeConversationItemMessageAssistantContentItemType.Text,
                _ => null,
            };
        }
    }
}