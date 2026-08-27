
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the summary part. Always `summary_text`.
    /// </summary>
    public enum BetaResponseReasoningSummaryPartAddedEventPartType
    {
        /// <summary>
        ///
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseReasoningSummaryPartAddedEventPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseReasoningSummaryPartAddedEventPartType value)
        {
            return value switch
            {
                BetaResponseReasoningSummaryPartAddedEventPartType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseReasoningSummaryPartAddedEventPartType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => BetaResponseReasoningSummaryPartAddedEventPartType.SummaryText,
                _ => null,
            };
        }
    }
}