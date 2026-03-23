
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type, `output_text` or `output_audio` depending on the session `output_modalities` configuration.
    /// </summary>
    public enum RealtimeConversationItemMessageAssistantContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputAudio,
        /// <summary>
        /// 
        /// </summary>
        OutputText,
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
                RealtimeConversationItemMessageAssistantContentItemType.OutputAudio => "output_audio",
                RealtimeConversationItemMessageAssistantContentItemType.OutputText => "output_text",
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
                "output_audio" => RealtimeConversationItemMessageAssistantContentItemType.OutputAudio,
                "output_text" => RealtimeConversationItemMessageAssistantContentItemType.OutputText,
                _ => null,
            };
        }
    }
}