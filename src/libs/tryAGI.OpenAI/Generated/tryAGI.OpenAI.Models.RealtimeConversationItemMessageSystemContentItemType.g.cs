
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type. Always `input_text` for system messages.
    /// </summary>
    public enum RealtimeConversationItemMessageSystemContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageSystemContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageSystemContentItemType value)
        {
            return value switch
            {
                RealtimeConversationItemMessageSystemContentItemType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageSystemContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => RealtimeConversationItemMessageSystemContentItemType.InputText,
                _ => null,
            };
        }
    }
}