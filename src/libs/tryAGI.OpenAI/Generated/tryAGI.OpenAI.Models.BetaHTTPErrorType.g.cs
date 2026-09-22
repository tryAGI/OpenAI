
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: http_error
    /// </summary>
    public enum BetaHTTPErrorType
    {
        /// <summary>
        ///
        /// </summary>
        HttpError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaHTTPErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaHTTPErrorType value)
        {
            return value switch
            {
                BetaHTTPErrorType.HttpError => "http_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaHTTPErrorType? ToEnum(string value)
        {
            return value switch
            {
                "http_error" => BetaHTTPErrorType.HttpError,
                _ => null,
            };
        }
    }
}