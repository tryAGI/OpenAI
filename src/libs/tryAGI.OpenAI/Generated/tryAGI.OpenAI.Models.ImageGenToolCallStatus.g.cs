
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the image generation call.
    /// </summary>
    public enum ImageGenToolCallStatus
    {
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
        Generating,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolCallStatus value)
        {
            return value switch
            {
                ImageGenToolCallStatus.InProgress => "in_progress",
                ImageGenToolCallStatus.Completed => "completed",
                ImageGenToolCallStatus.Generating => "generating",
                ImageGenToolCallStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ImageGenToolCallStatus.InProgress,
                "completed" => ImageGenToolCallStatus.Completed,
                "generating" => ImageGenToolCallStatus.Generating,
                "failed" => ImageGenToolCallStatus.Failed,
                _ => null,
            };
        }
    }
}