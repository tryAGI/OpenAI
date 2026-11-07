
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The minimum lifetime applied to every implicit and explicit cache breakpoint written by the request. Supported values are `30m` (the default) and `12h`. The backend may retain cache entries for longer.
    /// </summary>
    public enum ResponsePromptCacheOptionsParamTtl
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
    public static class ResponsePromptCacheOptionsParamTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePromptCacheOptionsParamTtl value)
        {
            return value switch
            {
                ResponsePromptCacheOptionsParamTtl.x12h => "12h",
                ResponsePromptCacheOptionsParamTtl.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePromptCacheOptionsParamTtl? ToEnum(string value)
        {
            return value switch
            {
                "12h" => ResponsePromptCacheOptionsParamTtl.x12h,
                "30m" => ResponsePromptCacheOptionsParamTtl.x30m,
                _ => null,
            };
        }
    }
}