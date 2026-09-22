
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The error type. Always `invalid_request_error`.
    /// </summary>
    public enum ResponseSteerFailedEventErrorType
    {
        /// <summary>
        ///
        /// </summary>
        InvalidRequestError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerFailedEventErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerFailedEventErrorType value)
        {
            return value switch
            {
                ResponseSteerFailedEventErrorType.InvalidRequestError => "invalid_request_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerFailedEventErrorType? ToEnum(string value)
        {
            return value switch
            {
                "invalid_request_error" => ResponseSteerFailedEventErrorType.InvalidRequestError,
                _ => null,
            };
        }
    }
}