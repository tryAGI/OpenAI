
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`.
    /// </summary>
    public enum BetaLocalShellToolCallOutputStatus
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
    public static class BetaLocalShellToolCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalShellToolCallOutputStatus value)
        {
            return value switch
            {
                BetaLocalShellToolCallOutputStatus.Completed => "completed",
                BetaLocalShellToolCallOutputStatus.InProgress => "in_progress",
                BetaLocalShellToolCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalShellToolCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaLocalShellToolCallOutputStatus.Completed,
                "in_progress" => BetaLocalShellToolCallOutputStatus.InProgress,
                "incomplete" => BetaLocalShellToolCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}