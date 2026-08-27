
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum BetaFunctionToolCallStatus
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
    public static class BetaFunctionToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionToolCallStatus value)
        {
            return value switch
            {
                BetaFunctionToolCallStatus.Completed => "completed",
                BetaFunctionToolCallStatus.InProgress => "in_progress",
                BetaFunctionToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFunctionToolCallStatus.Completed,
                "in_progress" => BetaFunctionToolCallStatus.InProgress,
                "incomplete" => BetaFunctionToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}