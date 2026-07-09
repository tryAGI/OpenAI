
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.inject.failed`.
    /// </summary>
    public enum BetaResponseInjectFailedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseInjectFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseInjectFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseInjectFailedEventType value)
        {
            return value switch
            {
                BetaResponseInjectFailedEventType.ResponseInjectFailed => "response.inject.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseInjectFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.inject.failed" => BetaResponseInjectFailedEventType.ResponseInjectFailed,
                _ => null,
            };
        }
    }
}