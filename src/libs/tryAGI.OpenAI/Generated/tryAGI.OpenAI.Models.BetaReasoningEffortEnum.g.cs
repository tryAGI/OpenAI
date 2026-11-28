
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaReasoningEffortEnum
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
    public static class BetaReasoningEffortEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningEffortEnum value)
        {
            return value switch
            {
                BetaReasoningEffortEnum.High => "high",
                BetaReasoningEffortEnum.Low => "low",
                BetaReasoningEffortEnum.Max => "max",
                BetaReasoningEffortEnum.Medium => "medium",
                BetaReasoningEffortEnum.Minimal => "minimal",
                BetaReasoningEffortEnum.None => "none",
                BetaReasoningEffortEnum.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningEffortEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaReasoningEffortEnum.High,
                "low" => BetaReasoningEffortEnum.Low,
                "max" => BetaReasoningEffortEnum.Max,
                "medium" => BetaReasoningEffortEnum.Medium,
                "minimal" => BetaReasoningEffortEnum.Minimal,
                "none" => BetaReasoningEffortEnum.None,
                "xhigh" => BetaReasoningEffortEnum.Xhigh,
                _ => null,
            };
        }
    }
}