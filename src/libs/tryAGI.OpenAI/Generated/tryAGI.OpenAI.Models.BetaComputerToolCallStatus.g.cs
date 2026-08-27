
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum BetaComputerToolCallStatus
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
    public static class BetaComputerToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerToolCallStatus value)
        {
            return value switch
            {
                BetaComputerToolCallStatus.Completed => "completed",
                BetaComputerToolCallStatus.InProgress => "in_progress",
                BetaComputerToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaComputerToolCallStatus.Completed,
                "in_progress" => BetaComputerToolCallStatus.InProgress,
                "incomplete" => BetaComputerToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}