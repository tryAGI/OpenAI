
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `error`.
    /// </summary>
    public enum BetaResponseErrorEventType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseErrorEventType value)
        {
            return value switch
            {
                BetaResponseErrorEventType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaResponseErrorEventType.Error,
                _ => null,
            };
        }
    }
}