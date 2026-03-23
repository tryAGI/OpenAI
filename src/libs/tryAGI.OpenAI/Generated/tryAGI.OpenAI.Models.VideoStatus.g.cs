
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
                VideoStatus.Completed => "completed",
                VideoStatus.Failed => "failed",
                VideoStatus.InProgress => "in_progress",
                VideoStatus.Queued => "queued",
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
                "completed" => VideoStatus.Completed,
                "failed" => VideoStatus.Failed,
                "in_progress" => VideoStatus.InProgress,
                "queued" => VideoStatus.Queued,
                _ => null,
            };
        }
    }
}