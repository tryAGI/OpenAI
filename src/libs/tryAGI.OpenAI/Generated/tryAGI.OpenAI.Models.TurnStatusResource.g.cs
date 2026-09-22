
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The current status of a turn.
    /// </summary>
    public enum TurnStatusResource
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
        Queued,
        /// <summary>
        ///
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnStatusResource value)
        {
            return value switch
            {
                TurnStatusResource.Cancelled => "cancelled",
                TurnStatusResource.Completed => "completed",
                TurnStatusResource.Failed => "failed",
                TurnStatusResource.InProgress => "in_progress",
                TurnStatusResource.Queued => "queued",
                TurnStatusResource.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => TurnStatusResource.Cancelled,
                "completed" => TurnStatusResource.Completed,
                "failed" => TurnStatusResource.Failed,
                "in_progress" => TurnStatusResource.InProgress,
                "queued" => TurnStatusResource.Queued,
                "waiting" => TurnStatusResource.Waiting,
                _ => null,
            };
        }
    }
}