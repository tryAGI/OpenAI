
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFunctionShellCallOutputStatusEnum
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
    public static class BetaFunctionShellCallOutputStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputStatusEnum value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputStatusEnum.Completed => "completed",
                BetaFunctionShellCallOutputStatusEnum.InProgress => "in_progress",
                BetaFunctionShellCallOutputStatusEnum.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFunctionShellCallOutputStatusEnum.Completed,
                "in_progress" => BetaFunctionShellCallOutputStatusEnum.InProgress,
                "incomplete" => BetaFunctionShellCallOutputStatusEnum.Incomplete,
                _ => null,
            };
        }
    }
}