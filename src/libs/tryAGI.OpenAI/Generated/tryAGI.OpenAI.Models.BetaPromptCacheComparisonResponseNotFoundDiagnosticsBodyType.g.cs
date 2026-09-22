
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: comparison_response_not_found
    /// </summary>
    public enum BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType
    {
        /// <summary>
        ///
        /// </summary>
        ComparisonResponseNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType value)
        {
            return value switch
            {
                BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound => "comparison_response_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType? ToEnum(string value)
        {
            return value switch
            {
                "comparison_response_not_found" => BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound,
                _ => null,
            };
        }
    }
}