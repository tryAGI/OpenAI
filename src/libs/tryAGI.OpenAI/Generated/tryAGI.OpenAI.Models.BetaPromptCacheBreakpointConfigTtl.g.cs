
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The minimum lifetime of this cache breakpoint. Defaults to the request TTL.
    /// </summary>
    public enum BetaPromptCacheBreakpointConfigTtl
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
    public static class BetaPromptCacheBreakpointConfigTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheBreakpointConfigTtl value)
        {
            return value switch
            {
                BetaPromptCacheBreakpointConfigTtl.x12h => "12h",
                BetaPromptCacheBreakpointConfigTtl.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheBreakpointConfigTtl? ToEnum(string value)
        {
            return value switch
            {
                "12h" => BetaPromptCacheBreakpointConfigTtl.x12h,
                "30m" => BetaPromptCacheBreakpointConfigTtl.x30m,
                _ => null,
            };
        }
    }
}