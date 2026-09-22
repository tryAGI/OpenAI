
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: cache_miss
    /// </summary>
    public enum PromptCacheMissDiagnosticsBodyType
    {
        /// <summary>
        ///
        /// </summary>
        CacheMiss,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheMissDiagnosticsBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheMissDiagnosticsBodyType value)
        {
            return value switch
            {
                PromptCacheMissDiagnosticsBodyType.CacheMiss => "cache_miss",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheMissDiagnosticsBodyType? ToEnum(string value)
        {
            return value switch
            {
                "cache_miss" => PromptCacheMissDiagnosticsBodyType.CacheMiss,
                _ => null,
            };
        }
    }
}