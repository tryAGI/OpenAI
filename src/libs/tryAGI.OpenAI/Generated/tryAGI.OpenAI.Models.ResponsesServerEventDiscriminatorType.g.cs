
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesServerEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        ResponseSteerAccepted,
        /// <summary>
        ///
        /// </summary>
        ResponseSteerFailed,
        /// <summary>
        ///
        /// </summary>
        ResponseSteerPending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesServerEventDiscriminatorType value)
        {
            return value switch
            {
                ResponsesServerEventDiscriminatorType.Error => "error",
                ResponsesServerEventDiscriminatorType.ResponseSteerAccepted => "response.steer.accepted",
                ResponsesServerEventDiscriminatorType.ResponseSteerFailed => "response.steer.failed",
                ResponsesServerEventDiscriminatorType.ResponseSteerPending => "response.steer.pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ResponsesServerEventDiscriminatorType.Error,
                "response.steer.accepted" => ResponsesServerEventDiscriminatorType.ResponseSteerAccepted,
                "response.steer.failed" => ResponsesServerEventDiscriminatorType.ResponseSteerFailed,
                "response.steer.pending" => ResponsesServerEventDiscriminatorType.ResponseSteerPending,
                _ => null,
            };
        }
    }
}