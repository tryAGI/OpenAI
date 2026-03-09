
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoStatus
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
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoStatus value)
        {
            return value switch
            {
                VideoStatus.Queued => "queued",
                VideoStatus.InProgress => "in_progress",
                VideoStatus.Completed => "completed",
                VideoStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => VideoStatus.Queued,
                "in_progress" => VideoStatus.InProgress,
                "completed" => VideoStatus.Completed,
                "failed" => VideoStatus.Failed,
                _ => null,
            };
        }
    }
}