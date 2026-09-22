
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerErrorCodeEnum
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
    public static class BetaResponseSteerErrorCodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerErrorCodeEnum value)
        {
            return value switch
            {
                BetaResponseSteerErrorCodeEnum.InvalidInput => "invalid_input",
                BetaResponseSteerErrorCodeEnum.ResponseAlreadyCompleted => "response_already_completed",
                BetaResponseSteerErrorCodeEnum.ResponseNotActive => "response_not_active",
                BetaResponseSteerErrorCodeEnum.ResponseNotFound => "response_not_found",
                BetaResponseSteerErrorCodeEnum.SteeringNotSupported => "steering_not_supported",
                BetaResponseSteerErrorCodeEnum.SuccessorCreationFailed => "successor_creation_failed",
                BetaResponseSteerErrorCodeEnum.TooManyPendingSteers => "too_many_pending_steers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerErrorCodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "invalid_input" => BetaResponseSteerErrorCodeEnum.InvalidInput,
                "response_already_completed" => BetaResponseSteerErrorCodeEnum.ResponseAlreadyCompleted,
                "response_not_active" => BetaResponseSteerErrorCodeEnum.ResponseNotActive,
                "response_not_found" => BetaResponseSteerErrorCodeEnum.ResponseNotFound,
                "steering_not_supported" => BetaResponseSteerErrorCodeEnum.SteeringNotSupported,
                "successor_creation_failed" => BetaResponseSteerErrorCodeEnum.SuccessorCreationFailed,
                "too_many_pending_steers" => BetaResponseSteerErrorCodeEnum.TooManyPendingSteers,
                _ => null,
            };
        }
    }
}