
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type (`input_text` or `input_audio`).
    /// </summary>
    public enum RealtimeConversationItemMessageUserContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageUserContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageUserContentItemType value)
        {
            return value switch
            {
                RealtimeConversationItemMessageUserContentItemType.InputText => "input_text",
                RealtimeConversationItemMessageUserContentItemType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageUserContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => RealtimeConversationItemMessageUserContentItemType.InputText,
                "input_audio" => RealtimeConversationItemMessageUserContentItemType.InputAudio,
                _ => null,
            };
        }
    }
}