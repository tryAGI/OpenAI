
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the web search tool call.
    /// </summary>
    public enum BetaWebSearchToolCallStatus
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
        Searching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchToolCallStatus value)
        {
            return value switch
            {
                BetaWebSearchToolCallStatus.Completed => "completed",
                BetaWebSearchToolCallStatus.Failed => "failed",
                BetaWebSearchToolCallStatus.InProgress => "in_progress",
                BetaWebSearchToolCallStatus.Searching => "searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaWebSearchToolCallStatus.Completed,
                "failed" => BetaWebSearchToolCallStatus.Failed,
                "in_progress" => BetaWebSearchToolCallStatus.InProgress,
                "searching" => BetaWebSearchToolCallStatus.Searching,
                _ => null,
            };
        }
    }
}