
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_summary_text.delta`.
    /// </summary>
    public enum BetaResponseReasoningSummaryTextDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseReasoningSummaryTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseReasoningSummaryTextDeltaEventType value)
        {
            return value switch
            {
                BetaResponseReasoningSummaryTextDeltaEventType.ResponseReasoningSummaryTextDelta => "response.reasoning_summary_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseReasoningSummaryTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_text.delta" => BetaResponseReasoningSummaryTextDeltaEventType.ResponseReasoningSummaryTextDelta,
                _ => null,
            };
        }
    }
}