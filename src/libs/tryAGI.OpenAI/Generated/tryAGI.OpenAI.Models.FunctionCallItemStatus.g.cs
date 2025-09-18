
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallItemStatus
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
    public static class FunctionCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallItemStatus value)
        {
            return value switch
            {
                FunctionCallItemStatus.InProgress => "in_progress",
                FunctionCallItemStatus.Completed => "completed",
                FunctionCallItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => FunctionCallItemStatus.InProgress,
                "completed" => FunctionCallItemStatus.Completed,
                "incomplete" => FunctionCallItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}