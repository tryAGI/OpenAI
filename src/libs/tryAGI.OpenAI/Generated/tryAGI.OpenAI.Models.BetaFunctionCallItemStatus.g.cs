
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFunctionCallItemStatus
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
    public static class BetaFunctionCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionCallItemStatus value)
        {
            return value switch
            {
                BetaFunctionCallItemStatus.Completed => "completed",
                BetaFunctionCallItemStatus.InProgress => "in_progress",
                BetaFunctionCallItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFunctionCallItemStatus.Completed,
                "in_progress" => BetaFunctionCallItemStatus.InProgress,
                "incomplete" => BetaFunctionCallItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}