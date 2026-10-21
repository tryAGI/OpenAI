
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The minimum lifetime of this cache breakpoint. Defaults to the request TTL.
    /// </summary>
    public enum PromptCacheBreakpointParamTtl
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
    public static class PromptCacheBreakpointParamTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheBreakpointParamTtl value)
        {
            return value switch
            {
                PromptCacheBreakpointParamTtl.x12h => "12h",
                PromptCacheBreakpointParamTtl.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheBreakpointParamTtl? ToEnum(string value)
        {
            return value switch
            {
                "12h" => PromptCacheBreakpointParamTtl.x12h,
                "30m" => PromptCacheBreakpointParamTtl.x30m,
                _ => null,
            };
        }
    }
}