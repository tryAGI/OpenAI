
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeMCPHTTPErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        HttpError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeMCPHTTPErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeMCPHTTPErrorType value)
        {
            return value switch
            {
                RealtimeMCPHTTPErrorType.HttpError => "http_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeMCPHTTPErrorType? ToEnum(string value)
        {
            return value switch
            {
                "http_error" => RealtimeMCPHTTPErrorType.HttpError,
                _ => null,
            };
        }
    }
}