
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: cache_hit
    /// </summary>
    public enum BetaPromptCacheHitDiagnosticsBodyType
    {
        /// <summary>
        ///
        /// </summary>
        CacheHit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheHitDiagnosticsBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheHitDiagnosticsBodyType value)
        {
            return value switch
            {
                BetaPromptCacheHitDiagnosticsBodyType.CacheHit => "cache_hit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheHitDiagnosticsBodyType? ToEnum(string value)
        {
            return value switch
            {
                "cache_hit" => BetaPromptCacheHitDiagnosticsBodyType.CacheHit,
                _ => null,
            };
        }
    }
}