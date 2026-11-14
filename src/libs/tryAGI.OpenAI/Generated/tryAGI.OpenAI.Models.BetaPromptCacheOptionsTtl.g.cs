
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The minimum lifetime applied to each cache breakpoint.
    /// </summary>
    public enum BetaPromptCacheOptionsTtl
    {
        /// <summary>
        ///
        /// </summary>
        x12h,
        /// <summary>
        ///
        /// </summary>
        x30m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheOptionsTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheOptionsTtl value)
        {
            return value switch
            {
                BetaPromptCacheOptionsTtl.x12h => "12h",
                BetaPromptCacheOptionsTtl.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheOptionsTtl? ToEnum(string value)
        {
            return value switch
            {
                "12h" => BetaPromptCacheOptionsTtl.x12h,
                "30m" => BetaPromptCacheOptionsTtl.x30m,
                _ => null,
            };
        }
    }
}