
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputMessageAssistantVariant2ContentItemType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputMessageAssistantVariant2ContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageAssistantVariant2ContentItemType value)
        {
            return value switch
            {
                RealtimeResponseInputMessageAssistantVariant2ContentItemType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageAssistantVariant2ContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => RealtimeResponseInputMessageAssistantVariant2ContentItemType.OutputText,
                _ => null,
            };
        }
    }
}