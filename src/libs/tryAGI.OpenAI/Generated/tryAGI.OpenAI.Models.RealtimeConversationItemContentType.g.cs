
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type (`input_text`, `input_audio`, `item_reference`, `text`, `audio`).
    /// </summary>
    public enum RealtimeConversationItemContentType
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
        ItemReference,
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
    public static class RealtimeConversationItemContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemContentType value)
        {
            return value switch
            {
                RealtimeConversationItemContentType.InputText => "input_text",
                RealtimeConversationItemContentType.InputAudio => "input_audio",
                RealtimeConversationItemContentType.ItemReference => "item_reference",
                RealtimeConversationItemContentType.Text => "text",
                RealtimeConversationItemContentType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemContentType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => RealtimeConversationItemContentType.InputText,
                "input_audio" => RealtimeConversationItemContentType.InputAudio,
                "item_reference" => RealtimeConversationItemContentType.ItemReference,
                "text" => RealtimeConversationItemContentType.Text,
                "audio" => RealtimeConversationItemContentType.Audio,
                _ => null,
            };
        }
    }
}