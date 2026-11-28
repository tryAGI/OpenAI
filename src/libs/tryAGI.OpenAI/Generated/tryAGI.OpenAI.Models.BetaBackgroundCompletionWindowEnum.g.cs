
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBackgroundCompletionWindowEnum
    {
        /// <summary>
        ///
        /// </summary>
        x2h,
        /// <summary>
        ///
        /// </summary>
        x8h,
        /// <summary>
        ///
        /// </summary>
        Soonest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBackgroundCompletionWindowEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBackgroundCompletionWindowEnum value)
        {
            return value switch
            {
                BetaBackgroundCompletionWindowEnum.x2h => "2h",
                BetaBackgroundCompletionWindowEnum.x8h => "8h",
                BetaBackgroundCompletionWindowEnum.Soonest => "soonest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBackgroundCompletionWindowEnum? ToEnum(string value)
        {
            return value switch
            {
                "2h" => BetaBackgroundCompletionWindowEnum.x2h,
                "8h" => BetaBackgroundCompletionWindowEnum.x8h,
                "soonest" => BetaBackgroundCompletionWindowEnum.Soonest,
                _ => null,
            };
        }
    }
}