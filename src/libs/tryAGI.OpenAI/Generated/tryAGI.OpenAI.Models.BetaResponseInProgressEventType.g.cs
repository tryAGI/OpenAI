
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.in_progress`.
    /// </summary>
    public enum BetaResponseInProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseInProgressEventType value)
        {
            return value switch
            {
                BetaResponseInProgressEventType.ResponseInProgress => "response.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.in_progress" => BetaResponseInProgressEventType.ResponseInProgress,
                _ => null,
            };
        }
    }
}