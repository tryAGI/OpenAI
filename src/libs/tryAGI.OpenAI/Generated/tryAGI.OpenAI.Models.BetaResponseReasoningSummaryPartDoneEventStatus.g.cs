
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The completion status of the summary part. Omitted when the part completed<br/>
    /// normally and set to `incomplete` when generation was interrupted.
    /// </summary>
    public enum BetaResponseReasoningSummaryPartDoneEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseReasoningSummaryPartDoneEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseReasoningSummaryPartDoneEventStatus value)
        {
            return value switch
            {
                BetaResponseReasoningSummaryPartDoneEventStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseReasoningSummaryPartDoneEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => BetaResponseReasoningSummaryPartDoneEventStatus.Incomplete,
                _ => null,
            };
        }
    }
}