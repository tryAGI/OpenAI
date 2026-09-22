
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: comparison_response_not_found
    /// </summary>
    public enum PromptCacheComparisonResponseNotFoundDiagnosticsBodyType
    {
        /// <summary>
        ///
        /// </summary>
        ComparisonResponseNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheComparisonResponseNotFoundDiagnosticsBodyType value)
        {
            return value switch
            {
                PromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound => "comparison_response_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheComparisonResponseNotFoundDiagnosticsBodyType? ToEnum(string value)
        {
            return value switch
            {
                "comparison_response_not_found" => PromptCacheComparisonResponseNotFoundDiagnosticsBodyType.ComparisonResponseNotFound,
                _ => null,
            };
        }
    }
}