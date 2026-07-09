
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the response generation. One of `completed`, `failed`,<br/>
    /// `in_progress`, `cancelled`, `queued`, or `incomplete`.
    /// </summary>
    public enum BetaResponseVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseVariant3Status value)
        {
            return value switch
            {
                BetaResponseVariant3Status.Cancelled => "cancelled",
                BetaResponseVariant3Status.Completed => "completed",
                BetaResponseVariant3Status.Failed => "failed",
                BetaResponseVariant3Status.InProgress => "in_progress",
                BetaResponseVariant3Status.Incomplete => "incomplete",
                BetaResponseVariant3Status.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => BetaResponseVariant3Status.Cancelled,
                "completed" => BetaResponseVariant3Status.Completed,
                "failed" => BetaResponseVariant3Status.Failed,
                "in_progress" => BetaResponseVariant3Status.InProgress,
                "incomplete" => BetaResponseVariant3Status.Incomplete,
                "queued" => BetaResponseVariant3Status.Queued,
                _ => null,
            };
        }
    }
}