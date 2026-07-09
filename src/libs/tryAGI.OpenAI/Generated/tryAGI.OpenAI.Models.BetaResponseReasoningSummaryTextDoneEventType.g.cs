
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_summary_text.done`.
    /// </summary>
    public enum BetaResponseReasoningSummaryTextDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseReasoningSummaryTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseReasoningSummaryTextDoneEventType value)
        {
            return value switch
            {
                BetaResponseReasoningSummaryTextDoneEventType.ResponseReasoningSummaryTextDone => "response.reasoning_summary_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseReasoningSummaryTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_text.done" => BetaResponseReasoningSummaryTextDoneEventType.ResponseReasoningSummaryTextDone,
                _ => null,
            };
        }
    }
}