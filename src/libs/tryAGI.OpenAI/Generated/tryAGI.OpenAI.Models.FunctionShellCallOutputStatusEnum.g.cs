
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionShellCallOutputStatusEnum
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
    public static class FunctionShellCallOutputStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputStatusEnum value)
        {
            return value switch
            {
                FunctionShellCallOutputStatusEnum.Completed => "completed",
                FunctionShellCallOutputStatusEnum.InProgress => "in_progress",
                FunctionShellCallOutputStatusEnum.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => FunctionShellCallOutputStatusEnum.Completed,
                "in_progress" => FunctionShellCallOutputStatusEnum.InProgress,
                "incomplete" => FunctionShellCallOutputStatusEnum.Incomplete,
                _ => null,
            };
        }
    }
}