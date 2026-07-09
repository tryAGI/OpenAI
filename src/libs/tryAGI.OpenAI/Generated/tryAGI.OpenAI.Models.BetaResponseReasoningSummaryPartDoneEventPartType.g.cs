
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the summary part. Always `summary_text`.
    /// </summary>
    public enum BetaResponseReasoningSummaryPartDoneEventPartType
    {
        /// <summary>
        /// 
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseReasoningSummaryPartDoneEventPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseReasoningSummaryPartDoneEventPartType value)
        {
            return value switch
            {
                BetaResponseReasoningSummaryPartDoneEventPartType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseReasoningSummaryPartDoneEventPartType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => BetaResponseReasoningSummaryPartDoneEventPartType.SummaryText,
                _ => null,
            };
        }
    }
}