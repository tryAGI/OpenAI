
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A machine-readable error code.
    /// </summary>
    public enum BetaResponseInjectFailedEventErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        ResponseAlreadyCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseInjectFailedEventErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseInjectFailedEventErrorCode value)
        {
            return value switch
            {
                BetaResponseInjectFailedEventErrorCode.ResponseAlreadyCompleted => "response_already_completed",
                BetaResponseInjectFailedEventErrorCode.ResponseNotFound => "response_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseInjectFailedEventErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "response_already_completed" => BetaResponseInjectFailedEventErrorCode.ResponseAlreadyCompleted,
                "response_not_found" => BetaResponseInjectFailedEventErrorCode.ResponseNotFound,
                _ => null,
            };
        }
    }
}