
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A summary of the reasoning performed by the model. This can be<br/>
    /// useful for debugging and understanding the model's reasoning process.<br/>
    /// One of `auto`, `concise`, or `detailed`.<br/>
    /// `concise` is supported for `computer-use-preview` models and all reasoning models after `gpt-5`.
    /// </summary>
    public enum BetaReasoningSummary2
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
    public static class BetaReasoningSummary2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningSummary2 value)
        {
            return value switch
            {
                BetaReasoningSummary2.Auto => "auto",
                BetaReasoningSummary2.Concise => "concise",
                BetaReasoningSummary2.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningSummary2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaReasoningSummary2.Auto,
                "concise" => BetaReasoningSummary2.Concise,
                "detailed" => BetaReasoningSummary2.Detailed,
                _ => null,
            };
        }
    }
}