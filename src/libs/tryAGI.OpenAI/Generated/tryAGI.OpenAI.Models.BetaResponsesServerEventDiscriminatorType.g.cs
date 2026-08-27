
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
        ResponseInjectCreated,
        /// <summary>
        ///
        /// </summary>
        ResponseInjectFailed,
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
                BetaResponsesServerEventDiscriminatorType.ResponseInjectCreated => "response.inject.created",
                BetaResponsesServerEventDiscriminatorType.ResponseInjectFailed => "response.inject.failed",
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
                "response.inject.created" => BetaResponsesServerEventDiscriminatorType.ResponseInjectCreated,
                "response.inject.failed" => BetaResponsesServerEventDiscriminatorType.ResponseInjectFailed,
                _ => null,
            };
        }
    }
}