
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: cache_hit
    /// </summary>
    public enum PromptCacheHitDiagnosticsBodyType
    {
        /// <summary>
        ///
        /// </summary>
        CacheHit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheHitDiagnosticsBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheHitDiagnosticsBodyType value)
        {
            return value switch
            {
                PromptCacheHitDiagnosticsBodyType.CacheHit => "cache_hit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheHitDiagnosticsBodyType? ToEnum(string value)
        {
            return value switch
            {
                "cache_hit" => PromptCacheHitDiagnosticsBodyType.CacheHit,
                _ => null,
            };
        }
    }
}