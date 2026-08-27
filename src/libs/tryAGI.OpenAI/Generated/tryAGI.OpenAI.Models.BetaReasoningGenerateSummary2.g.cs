
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// **Deprecated:** use `summary` instead.<br/>
    /// A summary of the reasoning performed by the model. This can be<br/>
    /// useful for debugging and understanding the model's reasoning process.<br/>
    /// One of `auto`, `concise`, or `detailed`.
    /// </summary>
    public enum BetaReasoningGenerateSummary2
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
    public static class BetaReasoningGenerateSummary2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningGenerateSummary2 value)
        {
            return value switch
            {
                BetaReasoningGenerateSummary2.Auto => "auto",
                BetaReasoningGenerateSummary2.Concise => "concise",
                BetaReasoningGenerateSummary2.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningGenerateSummary2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaReasoningGenerateSummary2.Auto,
                "concise" => BetaReasoningGenerateSummary2.Concise,
                "detailed" => BetaReasoningGenerateSummary2.Detailed,
                _ => null,
            };
        }
    }
}