
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundCompletionWindowEnum
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
    public static class BackgroundCompletionWindowEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundCompletionWindowEnum value)
        {
            return value switch
            {
                BackgroundCompletionWindowEnum.x2h => "2h",
                BackgroundCompletionWindowEnum.x8h => "8h",
                BackgroundCompletionWindowEnum.Soonest => "soonest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundCompletionWindowEnum? ToEnum(string value)
        {
            return value switch
            {
                "2h" => BackgroundCompletionWindowEnum.x2h,
                "8h" => BackgroundCompletionWindowEnum.x8h,
                "soonest" => BackgroundCompletionWindowEnum.Soonest,
                _ => null,
            };
        }
    }
}