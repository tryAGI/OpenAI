
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type.<br/>
    /// Example: input_text
    /// </summary>
    public enum RealtimeConversationItemContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemContentItemType value)
        {
            return value switch
            {
                RealtimeConversationItemContentItemType.InputText => "input_text",
                RealtimeConversationItemContentItemType.InputAudio => "input_audio",
                RealtimeConversationItemContentItemType.Text => "text",
                RealtimeConversationItemContentItemType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => RealtimeConversationItemContentItemType.InputText,
                "input_audio" => RealtimeConversationItemContentItemType.InputAudio,
                "text" => RealtimeConversationItemContentItemType.Text,
                "audio" => RealtimeConversationItemContentItemType.Audio,
                _ => null,
            };
        }
    }
}