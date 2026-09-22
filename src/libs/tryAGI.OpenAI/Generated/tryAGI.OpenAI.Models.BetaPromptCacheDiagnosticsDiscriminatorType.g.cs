
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPromptCacheDiagnosticsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CacheHit,
        /// <summary>
        ///
        /// </summary>
        CacheMiss,
        /// <summary>
        ///
        /// </summary>
        ComparisonResponseNotFound,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheDiagnosticsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheDiagnosticsDiscriminatorType value)
        {
            return value switch
            {
                BetaPromptCacheDiagnosticsDiscriminatorType.CacheHit => "cache_hit",
                BetaPromptCacheDiagnosticsDiscriminatorType.CacheMiss => "cache_miss",
                BetaPromptCacheDiagnosticsDiscriminatorType.ComparisonResponseNotFound => "comparison_response_not_found",
                BetaPromptCacheDiagnosticsDiscriminatorType.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheDiagnosticsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cache_hit" => BetaPromptCacheDiagnosticsDiscriminatorType.CacheHit,
                "cache_miss" => BetaPromptCacheDiagnosticsDiscriminatorType.CacheMiss,
                "comparison_response_not_found" => BetaPromptCacheDiagnosticsDiscriminatorType.ComparisonResponseNotFound,
                "unavailable" => BetaPromptCacheDiagnosticsDiscriminatorType.Unavailable,
                _ => null,
            };
        }
    }
}