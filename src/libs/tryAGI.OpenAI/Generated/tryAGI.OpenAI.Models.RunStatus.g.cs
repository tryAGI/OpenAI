
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`.
    /// </summary>
    public enum RunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
        /// <summary>
        /// 
        /// </summary>
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatus value)
        {
            return value switch
            {
                RunStatus.Queued => "queued",
                RunStatus.InProgress => "in_progress",
                RunStatus.RequiresAction => "requires_action",
                RunStatus.Cancelling => "cancelling",
                RunStatus.Cancelled => "cancelled",
                RunStatus.Failed => "failed",
                RunStatus.Completed => "completed",
                RunStatus.Incomplete => "incomplete",
                RunStatus.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => RunStatus.Queued,
                "in_progress" => RunStatus.InProgress,
                "requires_action" => RunStatus.RequiresAction,
                "cancelling" => RunStatus.Cancelling,
                "cancelled" => RunStatus.Cancelled,
                "failed" => RunStatus.Failed,
                "completed" => RunStatus.Completed,
                "incomplete" => RunStatus.Incomplete,
                "expired" => RunStatus.Expired,
                _ => null,
            };
        }
    }
}