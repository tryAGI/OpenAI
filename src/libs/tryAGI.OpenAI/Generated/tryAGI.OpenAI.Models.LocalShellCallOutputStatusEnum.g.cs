
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalShellCallOutputStatusEnum
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
    public static class LocalShellCallOutputStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellCallOutputStatusEnum value)
        {
            return value switch
            {
                LocalShellCallOutputStatusEnum.Completed => "completed",
                LocalShellCallOutputStatusEnum.InProgress => "in_progress",
                LocalShellCallOutputStatusEnum.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellCallOutputStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => LocalShellCallOutputStatusEnum.Completed,
                "in_progress" => LocalShellCallOutputStatusEnum.InProgress,
                "incomplete" => LocalShellCallOutputStatusEnum.Incomplete,
                _ => null,
            };
        }
    }
}