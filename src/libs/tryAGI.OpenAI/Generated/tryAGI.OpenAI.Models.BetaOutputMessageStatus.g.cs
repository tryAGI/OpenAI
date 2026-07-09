
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the message input. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when input items are returned via API.
    /// </summary>
    public enum BetaOutputMessageStatus
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
    public static class BetaOutputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputMessageStatus value)
        {
            return value switch
            {
                BetaOutputMessageStatus.Completed => "completed",
                BetaOutputMessageStatus.InProgress => "in_progress",
                BetaOutputMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaOutputMessageStatus.Completed,
                "in_progress" => BetaOutputMessageStatus.InProgress,
                "incomplete" => BetaOutputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}