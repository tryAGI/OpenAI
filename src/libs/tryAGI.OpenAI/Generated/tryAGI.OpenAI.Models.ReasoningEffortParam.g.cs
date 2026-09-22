
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The amount of reasoning effort the model should use.
    /// </summary>
    public enum ReasoningEffortParam
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
    public static class ReasoningEffortParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortParam value)
        {
            return value switch
            {
                ReasoningEffortParam.High => "high",
                ReasoningEffortParam.Low => "low",
                ReasoningEffortParam.Max => "max",
                ReasoningEffortParam.Medium => "medium",
                ReasoningEffortParam.Minimal => "minimal",
                ReasoningEffortParam.None => "none",
                ReasoningEffortParam.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortParam? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReasoningEffortParam.High,
                "low" => ReasoningEffortParam.Low,
                "max" => ReasoningEffortParam.Max,
                "medium" => ReasoningEffortParam.Medium,
                "minimal" => ReasoningEffortParam.Minimal,
                "none" => ReasoningEffortParam.None,
                "xhigh" => ReasoningEffortParam.Xhigh,
                _ => null,
            };
        }
    }
}