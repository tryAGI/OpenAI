
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum BetaInputMessageStatus
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
    public static class BetaInputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputMessageStatus value)
        {
            return value switch
            {
                BetaInputMessageStatus.Completed => "completed",
                BetaInputMessageStatus.InProgress => "in_progress",
                BetaInputMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaInputMessageStatus.Completed,
                "in_progress" => BetaInputMessageStatus.InProgress,
                "incomplete" => BetaInputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}