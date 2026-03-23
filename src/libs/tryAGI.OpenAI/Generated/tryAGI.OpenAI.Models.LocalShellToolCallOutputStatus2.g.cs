
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`.
    /// </summary>
    public enum LocalShellToolCallOutputStatus2
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
    public static class LocalShellToolCallOutputStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellToolCallOutputStatus2 value)
        {
            return value switch
            {
                LocalShellToolCallOutputStatus2.Completed => "completed",
                LocalShellToolCallOutputStatus2.InProgress => "in_progress",
                LocalShellToolCallOutputStatus2.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellToolCallOutputStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => LocalShellToolCallOutputStatus2.Completed,
                "in_progress" => LocalShellToolCallOutputStatus2.InProgress,
                "incomplete" => LocalShellToolCallOutputStatus2.Incomplete,
                _ => null,
            };
        }
    }
}