
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponsesServerEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        ResponseInjectCreated,
        /// <summary>
        ///
        /// </summary>
        ResponseInjectFailed,
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
    public static class BetaResponsesServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponsesServerEventDiscriminatorType value)
        {
            return value switch
            {
                BetaResponsesServerEventDiscriminatorType.Error => "error",
                BetaResponsesServerEventDiscriminatorType.ResponseInjectCreated => "response.inject.created",
                BetaResponsesServerEventDiscriminatorType.ResponseInjectFailed => "response.inject.failed",
                BetaResponsesServerEventDiscriminatorType.ResponseSteerAccepted => "response.steer.accepted",
                BetaResponsesServerEventDiscriminatorType.ResponseSteerFailed => "response.steer.failed",
                BetaResponsesServerEventDiscriminatorType.ResponseSteerPending => "response.steer.pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponsesServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaResponsesServerEventDiscriminatorType.Error,
                "response.inject.created" => BetaResponsesServerEventDiscriminatorType.ResponseInjectCreated,
                "response.inject.failed" => BetaResponsesServerEventDiscriminatorType.ResponseInjectFailed,
                "response.steer.accepted" => BetaResponsesServerEventDiscriminatorType.ResponseSteerAccepted,
                "response.steer.failed" => BetaResponsesServerEventDiscriminatorType.ResponseSteerFailed,
                "response.steer.pending" => BetaResponsesServerEventDiscriminatorType.ResponseSteerPending,
                _ => null,
            };
        }
    }
}