
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
        Completed,
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
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
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
                RealtimeBetaResponseStatus.Completed => "completed",
                RealtimeBetaResponseStatus.Cancelled => "cancelled",
                RealtimeBetaResponseStatus.Failed => "failed",
                RealtimeBetaResponseStatus.Incomplete => "incomplete",
                RealtimeBetaResponseStatus.InProgress => "in_progress",
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
                "completed" => RealtimeBetaResponseStatus.Completed,
                "cancelled" => RealtimeBetaResponseStatus.Cancelled,
                "failed" => RealtimeBetaResponseStatus.Failed,
                "incomplete" => RealtimeBetaResponseStatus.Incomplete,
                "in_progress" => RealtimeBetaResponseStatus.InProgress,
                _ => null,
            };
        }
    }
}