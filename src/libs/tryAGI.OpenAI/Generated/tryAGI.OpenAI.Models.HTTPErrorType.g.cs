
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: http_error
    /// </summary>
    public enum HTTPErrorType
    {
        /// <summary>
        ///
        /// </summary>
        HttpError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HTTPErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HTTPErrorType value)
        {
            return value switch
            {
                HTTPErrorType.HttpError => "http_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HTTPErrorType? ToEnum(string value)
        {
            return value switch
            {
                "http_error" => HTTPErrorType.HttpError,
                _ => null,
            };
        }
    }
}