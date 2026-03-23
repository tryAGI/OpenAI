
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Status values reported for shell tool calls.
    /// </summary>
    public enum FunctionShellCallItemStatus
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
    public static class FunctionShellCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallItemStatus value)
        {
            return value switch
            {
                FunctionShellCallItemStatus.Completed => "completed",
                FunctionShellCallItemStatus.InProgress => "in_progress",
                FunctionShellCallItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => FunctionShellCallItemStatus.Completed,
                "in_progress" => FunctionShellCallItemStatus.InProgress,
                "incomplete" => FunctionShellCallItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}