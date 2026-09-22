
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerErrorCodeEnum
    {
        /// <summary>
        ///
        /// </summary>
        InvalidInput,
        /// <summary>
        ///
        /// </summary>
        ResponseAlreadyCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseNotActive,
        /// <summary>
        ///
        /// </summary>
        ResponseNotFound,
        /// <summary>
        ///
        /// </summary>
        SteeringNotSupported,
        /// <summary>
        ///
        /// </summary>
        SuccessorCreationFailed,
        /// <summary>
        ///
        /// </summary>
        TooManyPendingSteers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerErrorCodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerErrorCodeEnum value)
        {
            return value switch
            {
                ResponseSteerErrorCodeEnum.InvalidInput => "invalid_input",
                ResponseSteerErrorCodeEnum.ResponseAlreadyCompleted => "response_already_completed",
                ResponseSteerErrorCodeEnum.ResponseNotActive => "response_not_active",
                ResponseSteerErrorCodeEnum.ResponseNotFound => "response_not_found",
                ResponseSteerErrorCodeEnum.SteeringNotSupported => "steering_not_supported",
                ResponseSteerErrorCodeEnum.SuccessorCreationFailed => "successor_creation_failed",
                ResponseSteerErrorCodeEnum.TooManyPendingSteers => "too_many_pending_steers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerErrorCodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "invalid_input" => ResponseSteerErrorCodeEnum.InvalidInput,
                "response_already_completed" => ResponseSteerErrorCodeEnum.ResponseAlreadyCompleted,
                "response_not_active" => ResponseSteerErrorCodeEnum.ResponseNotActive,
                "response_not_found" => ResponseSteerErrorCodeEnum.ResponseNotFound,
                "steering_not_supported" => ResponseSteerErrorCodeEnum.SteeringNotSupported,
                "successor_creation_failed" => ResponseSteerErrorCodeEnum.SuccessorCreationFailed,
                "too_many_pending_steers" => ResponseSteerErrorCodeEnum.TooManyPendingSteers,
                _ => null,
            };
        }
    }
}