
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Minimum lifetime for prompt cache entries written during the turn.
    /// </summary>
    public enum PromptCacheTtlParam
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
    public static class PromptCacheTtlParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheTtlParam value)
        {
            return value switch
            {
                PromptCacheTtlParam.x12h => "12h",
                PromptCacheTtlParam.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheTtlParam? ToEnum(string value)
        {
            return value switch
            {
                "12h" => PromptCacheTtlParam.x12h,
                "30m" => PromptCacheTtlParam.x30m,
                _ => null,
            };
        }
    }
}