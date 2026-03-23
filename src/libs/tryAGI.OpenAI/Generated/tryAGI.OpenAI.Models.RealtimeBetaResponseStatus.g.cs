
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The final status of the response (`completed`, `cancelled`, `failed`, or <br/>
    /// `incomplete`, `in_progress`).
    /// </summary>
    public enum RealtimeBetaResponseStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseStatus value)
        {
            return value switch
            {
                RealtimeBetaResponseStatus.Cancelled => "cancelled",
                RealtimeBetaResponseStatus.Completed => "completed",
                RealtimeBetaResponseStatus.Failed => "failed",
                RealtimeBetaResponseStatus.InProgress => "in_progress",
                RealtimeBetaResponseStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => RealtimeBetaResponseStatus.Cancelled,
                "completed" => RealtimeBetaResponseStatus.Completed,
                "failed" => RealtimeBetaResponseStatus.Failed,
                "in_progress" => RealtimeBetaResponseStatus.InProgress,
                "incomplete" => RealtimeBetaResponseStatus.Incomplete,
                _ => null,
            };
        }
    }
}