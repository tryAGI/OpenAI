
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveReasoningEffort
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
    public static class LiveReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveReasoningEffort value)
        {
            return value switch
            {
                LiveReasoningEffort.High => "high",
                LiveReasoningEffort.Low => "low",
                LiveReasoningEffort.Medium => "medium",
                LiveReasoningEffort.Minimal => "minimal",
                LiveReasoningEffort.None => "none",
                LiveReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => LiveReasoningEffort.High,
                "low" => LiveReasoningEffort.Low,
                "medium" => LiveReasoningEffort.Medium,
                "minimal" => LiveReasoningEffort.Minimal,
                "none" => LiveReasoningEffort.None,
                "xhigh" => LiveReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}