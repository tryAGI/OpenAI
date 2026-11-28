
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptCacheTtlResource
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
    public static class PromptCacheTtlResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheTtlResource value)
        {
            return value switch
            {
                PromptCacheTtlResource.x12h => "12h",
                PromptCacheTtlResource.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheTtlResource? ToEnum(string value)
        {
            return value switch
            {
                "12h" => PromptCacheTtlResource.x12h,
                "30m" => PromptCacheTtlResource.x30m,
                _ => null,
            };
        }
    }
}