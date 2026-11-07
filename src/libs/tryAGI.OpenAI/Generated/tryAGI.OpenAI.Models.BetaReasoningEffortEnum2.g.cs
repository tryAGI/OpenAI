
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaReasoningEffortEnum2
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaReasoningEffortEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningEffortEnum2 value)
        {
            return value switch
            {
                BetaReasoningEffortEnum2.High => "high",
                BetaReasoningEffortEnum2.Low => "low",
                BetaReasoningEffortEnum2.Max => "max",
                BetaReasoningEffortEnum2.Medium => "medium",
                BetaReasoningEffortEnum2.Minimal => "minimal",
                BetaReasoningEffortEnum2.None => "none",
                BetaReasoningEffortEnum2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningEffortEnum2? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaReasoningEffortEnum2.High,
                "low" => BetaReasoningEffortEnum2.Low,
                "max" => BetaReasoningEffortEnum2.Max,
                "medium" => BetaReasoningEffortEnum2.Medium,
                "minimal" => BetaReasoningEffortEnum2.Minimal,
                "none" => BetaReasoningEffortEnum2.None,
                "xhigh" => BetaReasoningEffortEnum2.Xhigh,
                _ => null,
            };
        }
    }
}