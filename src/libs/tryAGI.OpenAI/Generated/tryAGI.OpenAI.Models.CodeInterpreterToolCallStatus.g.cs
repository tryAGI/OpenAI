
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the code interpreter tool call. Valid values are `in_progress`, `completed`, `incomplete`, `interpreting`, and `failed`.
    /// </summary>
    public enum CodeInterpreterToolCallStatus
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
        Interpreting,
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
                CodeInterpreterToolCallStatus.Completed => "completed",
                CodeInterpreterToolCallStatus.Failed => "failed",
                CodeInterpreterToolCallStatus.InProgress => "in_progress",
                CodeInterpreterToolCallStatus.Incomplete => "incomplete",
                CodeInterpreterToolCallStatus.Interpreting => "interpreting",
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
                "completed" => CodeInterpreterToolCallStatus.Completed,
                "failed" => CodeInterpreterToolCallStatus.Failed,
                "in_progress" => CodeInterpreterToolCallStatus.InProgress,
                "incomplete" => CodeInterpreterToolCallStatus.Incomplete,
                "interpreting" => CodeInterpreterToolCallStatus.Interpreting,
                _ => null,
            };
        }
    }
}