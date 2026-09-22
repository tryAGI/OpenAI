
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The amount of reasoning effort used by an agent.
    /// </summary>
    public enum ReasoningEffortResource
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
    public static class ReasoningEffortResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortResource value)
        {
            return value switch
            {
                ReasoningEffortResource.High => "high",
                ReasoningEffortResource.Low => "low",
                ReasoningEffortResource.Max => "max",
                ReasoningEffortResource.Medium => "medium",
                ReasoningEffortResource.Minimal => "minimal",
                ReasoningEffortResource.None => "none",
                ReasoningEffortResource.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortResource? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReasoningEffortResource.High,
                "low" => ReasoningEffortResource.Low,
                "max" => ReasoningEffortResource.Max,
                "medium" => ReasoningEffortResource.Medium,
                "minimal" => ReasoningEffortResource.Minimal,
                "none" => ReasoningEffortResource.None,
                "xhigh" => ReasoningEffortResource.Xhigh,
                _ => null,
            };
        }
    }
}