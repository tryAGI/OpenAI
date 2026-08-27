
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFunctionCallOutputStatusEnum
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
    public static class BetaFunctionCallOutputStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionCallOutputStatusEnum value)
        {
            return value switch
            {
                BetaFunctionCallOutputStatusEnum.Completed => "completed",
                BetaFunctionCallOutputStatusEnum.InProgress => "in_progress",
                BetaFunctionCallOutputStatusEnum.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionCallOutputStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFunctionCallOutputStatusEnum.Completed,
                "in_progress" => BetaFunctionCallOutputStatusEnum.InProgress,
                "incomplete" => BetaFunctionCallOutputStatusEnum.Incomplete,
                _ => null,
            };
        }
    }
}