
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoSize
    {
        /// <summary>
        /// 
        /// </summary>
        x720x1280,
        /// <summary>
        /// 
        /// </summary>
        x1280x720,
        /// <summary>
        /// 
        /// </summary>
        x1024x1792,
        /// <summary>
        /// 
        /// </summary>
        x1792x1024,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSize value)
        {
            return value switch
            {
                VideoSize.x720x1280 => "720x1280",
                VideoSize.x1280x720 => "1280x720",
                VideoSize.x1024x1792 => "1024x1792",
                VideoSize.x1792x1024 => "1792x1024",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSize? ToEnum(string value)
        {
            return value switch
            {
                "720x1280" => VideoSize.x720x1280,
                "1280x720" => VideoSize.x1280x720,
                "1024x1792" => VideoSize.x1024x1792,
                "1792x1024" => VideoSize.x1792x1024,
                _ => null,
            };
        }
    }
}