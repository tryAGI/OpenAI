
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the code interpreter tool call.
    /// </summary>
    public enum CodeInterpreterToolCallStatus
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
        /// <summary>
        /// 
        /// </summary>
        Interpreting,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterToolCallStatus value)
        {
            return value switch
            {
                CodeInterpreterToolCallStatus.InProgress => "in_progress",
                CodeInterpreterToolCallStatus.Completed => "completed",
                CodeInterpreterToolCallStatus.Incomplete => "incomplete",
                CodeInterpreterToolCallStatus.Interpreting => "interpreting",
                CodeInterpreterToolCallStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => CodeInterpreterToolCallStatus.InProgress,
                "completed" => CodeInterpreterToolCallStatus.Completed,
                "incomplete" => CodeInterpreterToolCallStatus.Incomplete,
                "interpreting" => CodeInterpreterToolCallStatus.Interpreting,
                "failed" => CodeInterpreterToolCallStatus.Failed,
                _ => null,
            };
        }
    }
}