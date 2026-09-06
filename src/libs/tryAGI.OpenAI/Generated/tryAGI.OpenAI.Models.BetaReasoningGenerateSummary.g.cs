
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// **Deprecated:** use `summary` instead.<br/>
    /// A summary of the reasoning performed by the model. This can be<br/>
    /// useful for debugging and understanding the model's reasoning process.<br/>
    /// One of `auto`, `concise`, or `detailed`.
    /// </summary>
    public enum BetaReasoningGenerateSummary
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Concise,
        /// <summary>
        ///
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaReasoningGenerateSummaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningGenerateSummary value)
        {
            return value switch
            {
                BetaReasoningGenerateSummary.Auto => "auto",
                BetaReasoningGenerateSummary.Concise => "concise",
                BetaReasoningGenerateSummary.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningGenerateSummary? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaReasoningGenerateSummary.Auto,
                "concise" => BetaReasoningGenerateSummary.Concise,
                "detailed" => BetaReasoningGenerateSummary.Detailed,
                _ => null,
            };
        }
    }
}