
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_summary_part.added`.
    /// </summary>
    public enum BetaResponseReasoningSummaryPartAddedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseReasoningSummaryPartAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseReasoningSummaryPartAddedEventType value)
        {
            return value switch
            {
                BetaResponseReasoningSummaryPartAddedEventType.ResponseReasoningSummaryPartAdded => "response.reasoning_summary_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseReasoningSummaryPartAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_part.added" => BetaResponseReasoningSummaryPartAddedEventType.ResponseReasoningSummaryPartAdded,
                _ => null,
            };
        }
    }
}