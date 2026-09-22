
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: unavailable
    /// </summary>
    public enum BetaPromptCacheUnavailableDiagnosticsBodyType
    {
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheUnavailableDiagnosticsBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheUnavailableDiagnosticsBodyType value)
        {
            return value switch
            {
                BetaPromptCacheUnavailableDiagnosticsBodyType.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheUnavailableDiagnosticsBodyType? ToEnum(string value)
        {
            return value switch
            {
                "unavailable" => BetaPromptCacheUnavailableDiagnosticsBodyType.Unavailable,
                _ => null,
            };
        }
    }
}