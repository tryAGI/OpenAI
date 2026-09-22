
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `error`.
    /// </summary>
    public enum BetaResponseWsErrorType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWsErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWsErrorType value)
        {
            return value switch
            {
                BetaResponseWsErrorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWsErrorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaResponseWsErrorType.Error,
                _ => null,
            };
        }
    }
}