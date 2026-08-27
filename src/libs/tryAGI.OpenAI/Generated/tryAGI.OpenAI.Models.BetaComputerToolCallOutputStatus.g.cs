
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the message input. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when input items are returned via API.
    /// </summary>
    public enum BetaComputerToolCallOutputStatus
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
    public static class BetaComputerToolCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerToolCallOutputStatus value)
        {
            return value switch
            {
                BetaComputerToolCallOutputStatus.Completed => "completed",
                BetaComputerToolCallOutputStatus.InProgress => "in_progress",
                BetaComputerToolCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerToolCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaComputerToolCallOutputStatus.Completed,
                "in_progress" => BetaComputerToolCallOutputStatus.InProgress,
                "incomplete" => BetaComputerToolCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}