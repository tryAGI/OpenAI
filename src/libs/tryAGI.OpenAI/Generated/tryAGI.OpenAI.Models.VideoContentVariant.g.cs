
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoContentVariant
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Thumbnail,
        /// <summary>
        /// 
        /// </summary>
        Spritesheet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContentVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContentVariant value)
        {
            return value switch
            {
                VideoContentVariant.Video => "video",
                VideoContentVariant.Thumbnail => "thumbnail",
                VideoContentVariant.Spritesheet => "spritesheet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContentVariant? ToEnum(string value)
        {
            return value switch
            {
                "video" => VideoContentVariant.Video,
                "thumbnail" => VideoContentVariant.Thumbnail,
                "spritesheet" => VideoContentVariant.Spritesheet,
                _ => null,
            };
        }
    }
}