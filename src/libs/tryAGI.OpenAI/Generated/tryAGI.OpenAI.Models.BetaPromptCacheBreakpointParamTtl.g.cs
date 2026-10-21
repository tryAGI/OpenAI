
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The minimum lifetime of this cache breakpoint. Defaults to the request TTL.
    /// </summary>
    public enum BetaPromptCacheBreakpointParamTtl
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
    public static class BetaPromptCacheBreakpointParamTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheBreakpointParamTtl value)
        {
            return value switch
            {
                BetaPromptCacheBreakpointParamTtl.x12h => "12h",
                BetaPromptCacheBreakpointParamTtl.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheBreakpointParamTtl? ToEnum(string value)
        {
            return value switch
            {
                "12h" => BetaPromptCacheBreakpointParamTtl.x12h,
                "30m" => BetaPromptCacheBreakpointParamTtl.x30m,
                _ => null,
            };
        }
    }
}