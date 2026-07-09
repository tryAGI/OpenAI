
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaReasoningModeEnumEnum
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
    public static class BetaReasoningModeEnumEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningModeEnumEnum value)
        {
            return value switch
            {
                BetaReasoningModeEnumEnum.Pro => "pro",
                BetaReasoningModeEnumEnum.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningModeEnumEnum? ToEnum(string value)
        {
            return value switch
            {
                "pro" => BetaReasoningModeEnumEnum.Pro,
                "standard" => BetaReasoningModeEnumEnum.Standard,
                _ => null,
            };
        }
    }
}