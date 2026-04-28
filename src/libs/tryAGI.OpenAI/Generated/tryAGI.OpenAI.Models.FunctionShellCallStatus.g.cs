
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionShellCallStatus
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
    public static class FunctionShellCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallStatus value)
        {
            return value switch
            {
                FunctionShellCallStatus.Completed => "completed",
                FunctionShellCallStatus.InProgress => "in_progress",
                FunctionShellCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => FunctionShellCallStatus.Completed,
                "in_progress" => FunctionShellCallStatus.InProgress,
                "incomplete" => FunctionShellCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}