
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallOutputStatusEnum
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
    public static class FunctionCallOutputStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallOutputStatusEnum value)
        {
            return value switch
            {
                FunctionCallOutputStatusEnum.InProgress => "in_progress",
                FunctionCallOutputStatusEnum.Completed => "completed",
                FunctionCallOutputStatusEnum.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallOutputStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => FunctionCallOutputStatusEnum.InProgress,
                "completed" => FunctionCallOutputStatusEnum.Completed,
                "incomplete" => FunctionCallOutputStatusEnum.Incomplete,
                _ => null,
            };
        }
    }
}