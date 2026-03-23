
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
        Spritesheet,
        /// <summary>
        /// 
        /// </summary>
        Thumbnail,
        /// <summary>
        /// 
        /// </summary>
        Video,
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
                VideoContentVariant.Spritesheet => "spritesheet",
                VideoContentVariant.Thumbnail => "thumbnail",
                VideoContentVariant.Video => "video",
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
                "spritesheet" => VideoContentVariant.Spritesheet,
                "thumbnail" => VideoContentVariant.Thumbnail,
                "video" => VideoContentVariant.Video,
                _ => null,
            };
        }
    }
}