
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ReasoningEffortEnum2
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
    public static class ReasoningEffortEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortEnum2 value)
        {
            return value switch
            {
                ReasoningEffortEnum2.High => "high",
                ReasoningEffortEnum2.Low => "low",
                ReasoningEffortEnum2.Max => "max",
                ReasoningEffortEnum2.Medium => "medium",
                ReasoningEffortEnum2.Minimal => "minimal",
                ReasoningEffortEnum2.None => "none",
                ReasoningEffortEnum2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortEnum2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReasoningEffortEnum2.High,
                "low" => ReasoningEffortEnum2.Low,
                "max" => ReasoningEffortEnum2.Max,
                "medium" => ReasoningEffortEnum2.Medium,
                "minimal" => ReasoningEffortEnum2.Minimal,
                "none" => ReasoningEffortEnum2.None,
                "xhigh" => ReasoningEffortEnum2.Xhigh,
                _ => null,
            };
        }
    }
}