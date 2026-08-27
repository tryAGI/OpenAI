
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_summary_part.done`.
    /// </summary>
    public enum BetaResponseReasoningSummaryPartDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseReasoningSummaryPartDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseReasoningSummaryPartDoneEventType value)
        {
            return value switch
            {
                BetaResponseReasoningSummaryPartDoneEventType.ResponseReasoningSummaryPartDone => "response.reasoning_summary_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseReasoningSummaryPartDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_part.done" => BetaResponseReasoningSummaryPartDoneEventType.ResponseReasoningSummaryPartDone,
                _ => null,
            };
        }
    }
}