
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The error type. Always `invalid_request_error`.
    /// </summary>
    public enum BetaResponseSteerFailedEventErrorType
    {
        /// <summary>
        ///
        /// </summary>
        InvalidRequestError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerFailedEventErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerFailedEventErrorType value)
        {
            return value switch
            {
                BetaResponseSteerFailedEventErrorType.InvalidRequestError => "invalid_request_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerFailedEventErrorType? ToEnum(string value)
        {
            return value switch
            {
                "invalid_request_error" => BetaResponseSteerFailedEventErrorType.InvalidRequestError,
                _ => null,
            };
        }
    }
}