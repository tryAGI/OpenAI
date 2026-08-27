
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the file search tool call. One of `in_progress`,<br/>
    /// `searching`, `incomplete` or `failed`,
    /// </summary>
    public enum BetaFileSearchToolCallStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Incomplete,
        /// <summary>
        ///
        /// </summary>
        Searching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileSearchToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileSearchToolCallStatus value)
        {
            return value switch
            {
                BetaFileSearchToolCallStatus.Completed => "completed",
                BetaFileSearchToolCallStatus.Failed => "failed",
                BetaFileSearchToolCallStatus.InProgress => "in_progress",
                BetaFileSearchToolCallStatus.Incomplete => "incomplete",
                BetaFileSearchToolCallStatus.Searching => "searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileSearchToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFileSearchToolCallStatus.Completed,
                "failed" => BetaFileSearchToolCallStatus.Failed,
                "in_progress" => BetaFileSearchToolCallStatus.InProgress,
                "incomplete" => BetaFileSearchToolCallStatus.Incomplete,
                "searching" => BetaFileSearchToolCallStatus.Searching,
                _ => null,
            };
        }
    }
}