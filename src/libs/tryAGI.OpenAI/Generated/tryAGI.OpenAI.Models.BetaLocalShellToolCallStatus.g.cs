
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the local shell call.
    /// </summary>
    public enum BetaLocalShellToolCallStatus
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
    public static class BetaLocalShellToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLocalShellToolCallStatus value)
        {
            return value switch
            {
                BetaLocalShellToolCallStatus.Completed => "completed",
                BetaLocalShellToolCallStatus.InProgress => "in_progress",
                BetaLocalShellToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLocalShellToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaLocalShellToolCallStatus.Completed,
                "in_progress" => BetaLocalShellToolCallStatus.InProgress,
                "incomplete" => BetaLocalShellToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}