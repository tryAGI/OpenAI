
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallStatus
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
    public static class FunctionCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallStatus value)
        {
            return value switch
            {
                FunctionCallStatus.InProgress => "in_progress",
                FunctionCallStatus.Completed => "completed",
                FunctionCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => FunctionCallStatus.InProgress,
                "completed" => FunctionCallStatus.Completed,
                "incomplete" => FunctionCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}