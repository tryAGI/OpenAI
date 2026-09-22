
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptCacheDiagnosticsDiscriminatorType
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
    public static class PromptCacheDiagnosticsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheDiagnosticsDiscriminatorType value)
        {
            return value switch
            {
                PromptCacheDiagnosticsDiscriminatorType.CacheHit => "cache_hit",
                PromptCacheDiagnosticsDiscriminatorType.CacheMiss => "cache_miss",
                PromptCacheDiagnosticsDiscriminatorType.ComparisonResponseNotFound => "comparison_response_not_found",
                PromptCacheDiagnosticsDiscriminatorType.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheDiagnosticsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cache_hit" => PromptCacheDiagnosticsDiscriminatorType.CacheHit,
                "cache_miss" => PromptCacheDiagnosticsDiscriminatorType.CacheMiss,
                "comparison_response_not_found" => PromptCacheDiagnosticsDiscriminatorType.ComparisonResponseNotFound,
                "unavailable" => PromptCacheDiagnosticsDiscriminatorType.Unavailable,
                _ => null,
            };
        }
    }
}