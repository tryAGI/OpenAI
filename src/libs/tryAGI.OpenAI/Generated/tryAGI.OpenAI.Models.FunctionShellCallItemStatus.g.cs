
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
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
                FunctionShellCallItemStatus.InProgress => "in_progress",
                FunctionShellCallItemStatus.Completed => "completed",
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
                "in_progress" => FunctionShellCallItemStatus.InProgress,
                "completed" => FunctionShellCallItemStatus.Completed,
                "incomplete" => FunctionShellCallItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}