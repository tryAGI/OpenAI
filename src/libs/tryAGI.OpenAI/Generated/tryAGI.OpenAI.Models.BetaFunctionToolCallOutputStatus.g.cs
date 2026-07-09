
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum BetaFunctionToolCallOutputStatus
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
    public static class BetaFunctionToolCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionToolCallOutputStatus value)
        {
            return value switch
            {
                BetaFunctionToolCallOutputStatus.Completed => "completed",
                BetaFunctionToolCallOutputStatus.InProgress => "in_progress",
                BetaFunctionToolCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionToolCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFunctionToolCallOutputStatus.Completed,
                "in_progress" => BetaFunctionToolCallOutputStatus.InProgress,
                "incomplete" => BetaFunctionToolCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}