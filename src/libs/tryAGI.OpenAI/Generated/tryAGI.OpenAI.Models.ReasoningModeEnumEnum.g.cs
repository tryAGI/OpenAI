
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningModeEnumEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Pro,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningModeEnumEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningModeEnumEnum value)
        {
            return value switch
            {
                ReasoningModeEnumEnum.Pro => "pro",
                ReasoningModeEnumEnum.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningModeEnumEnum? ToEnum(string value)
        {
            return value switch
            {
                "pro" => ReasoningModeEnumEnum.Pro,
                "standard" => ReasoningModeEnumEnum.Standard,
                _ => null,
            };
        }
    }
}