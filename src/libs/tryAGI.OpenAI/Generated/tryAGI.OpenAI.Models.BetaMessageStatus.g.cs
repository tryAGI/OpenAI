
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMessageStatus
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
    public static class BetaMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageStatus value)
        {
            return value switch
            {
                BetaMessageStatus.Completed => "completed",
                BetaMessageStatus.InProgress => "in_progress",
                BetaMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaMessageStatus.Completed,
                "in_progress" => BetaMessageStatus.InProgress,
                "incomplete" => BetaMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}