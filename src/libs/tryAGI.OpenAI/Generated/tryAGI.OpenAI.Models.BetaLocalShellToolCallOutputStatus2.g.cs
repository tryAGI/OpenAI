
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`.
    /// </summary>
    public enum BetaLocalShellToolCallOutputStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaLocalShellToolCallOutputStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalShellToolCallOutputStatus2 value)
        {
            return value switch
            {
                BetaLocalShellToolCallOutputStatus2.Completed => "completed",
                BetaLocalShellToolCallOutputStatus2.InProgress => "in_progress",
                BetaLocalShellToolCallOutputStatus2.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalShellToolCallOutputStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaLocalShellToolCallOutputStatus2.Completed,
                "in_progress" => BetaLocalShellToolCallOutputStatus2.InProgress,
                "incomplete" => BetaLocalShellToolCallOutputStatus2.Incomplete,
                _ => null,
            };
        }
    }
}