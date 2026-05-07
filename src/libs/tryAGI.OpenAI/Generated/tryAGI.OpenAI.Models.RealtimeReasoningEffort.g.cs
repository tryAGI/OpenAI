
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains effort on reasoning for reasoning-capable Realtime models such as<br/>
    /// `gpt-realtime-2`.<br/>
    /// Default Value: low
    /// </summary>
    public enum RealtimeReasoningEffort
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
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeReasoningEffort value)
        {
            return value switch
            {
                RealtimeReasoningEffort.High => "high",
                RealtimeReasoningEffort.Low => "low",
                RealtimeReasoningEffort.Medium => "medium",
                RealtimeReasoningEffort.Minimal => "minimal",
                RealtimeReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => RealtimeReasoningEffort.High,
                "low" => RealtimeReasoningEffort.Low,
                "medium" => RealtimeReasoningEffort.Medium,
                "minimal" => RealtimeReasoningEffort.Minimal,
                "xhigh" => RealtimeReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}