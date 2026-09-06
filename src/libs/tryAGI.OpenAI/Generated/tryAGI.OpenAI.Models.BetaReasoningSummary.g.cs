
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A summary of the reasoning performed by the model. This can be<br/>
    /// useful for debugging and understanding the model's reasoning process.<br/>
    /// One of `auto`, `concise`, or `detailed`.<br/>
    /// `concise` is supported for `computer-use-preview` models and all reasoning models after `gpt-5`.
    /// </summary>
    public enum BetaReasoningSummary
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
    public static class BetaReasoningSummaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningSummary value)
        {
            return value switch
            {
                BetaReasoningSummary.Auto => "auto",
                BetaReasoningSummary.Concise => "concise",
                BetaReasoningSummary.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningSummary? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaReasoningSummary.Auto,
                "concise" => BetaReasoningSummary.Concise,
                "detailed" => BetaReasoningSummary.Detailed,
                _ => null,
            };
        }
    }
}