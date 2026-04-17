
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The content type (`input_text`, `input_audio`, or `input_image`).
    /// </summary>
    public enum RealtimeConversationItemMessageUserContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
        /// <summary>
        /// 
        /// </summary>
        InputImage,
        /// <summary>
        /// 
        /// </summary>
        InputText,
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
                RealtimeConversationItemMessageUserContentItemType.InputAudio => "input_audio",
                RealtimeConversationItemMessageUserContentItemType.InputImage => "input_image",
                RealtimeConversationItemMessageUserContentItemType.InputText => "input_text",
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
                "input_audio" => RealtimeConversationItemMessageUserContentItemType.InputAudio,
                "input_image" => RealtimeConversationItemMessageUserContentItemType.InputImage,
                "input_text" => RealtimeConversationItemMessageUserContentItemType.InputText,
                _ => null,
            };
        }
    }
}