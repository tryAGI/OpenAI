
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: cache_miss
    /// </summary>
    public enum BetaPromptCacheMissDiagnosticsBodyType
    {
        /// <summary>
        ///
        /// </summary>
        CacheMiss,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheMissDiagnosticsBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheMissDiagnosticsBodyType value)
        {
            return value switch
            {
                BetaPromptCacheMissDiagnosticsBodyType.CacheMiss => "cache_miss",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheMissDiagnosticsBodyType? ToEnum(string value)
        {
            return value switch
            {
                "cache_miss" => BetaPromptCacheMissDiagnosticsBodyType.CacheMiss,
                _ => null,
            };
        }
    }
}