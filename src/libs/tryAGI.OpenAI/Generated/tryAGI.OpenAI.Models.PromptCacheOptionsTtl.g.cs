
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The minimum lifetime applied to each cache breakpoint.
    /// </summary>
    public enum PromptCacheOptionsTtl
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
    public static class PromptCacheOptionsTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheOptionsTtl value)
        {
            return value switch
            {
                PromptCacheOptionsTtl.x12h => "12h",
                PromptCacheOptionsTtl.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheOptionsTtl? ToEnum(string value)
        {
            return value switch
            {
                "12h" => PromptCacheOptionsTtl.x12h,
                "30m" => PromptCacheOptionsTtl.x30m,
                _ => null,
            };
        }
    }
}