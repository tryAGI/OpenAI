
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The minimum lifetime of this cache breakpoint. Defaults to the request TTL.
    /// </summary>
    public enum PromptCacheBreakpointConfigTtl
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
    public static class PromptCacheBreakpointConfigTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheBreakpointConfigTtl value)
        {
            return value switch
            {
                PromptCacheBreakpointConfigTtl.x12h => "12h",
                PromptCacheBreakpointConfigTtl.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheBreakpointConfigTtl? ToEnum(string value)
        {
            return value switch
            {
                "12h" => PromptCacheBreakpointConfigTtl.x12h,
                "30m" => PromptCacheBreakpointConfigTtl.x30m,
                _ => null,
            };
        }
    }
}