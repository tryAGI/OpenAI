
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `reasoning_text`.
    /// </summary>
    public enum ReasoningItemContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ReasoningText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningItemContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningItemContentItemType value)
        {
            return value switch
            {
                ReasoningItemContentItemType.ReasoningText => "reasoning_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningItemContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning_text" => ReasoningItemContentItemType.ReasoningText,
                _ => null,
            };
        }
    }
}