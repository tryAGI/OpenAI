
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The size of the requested image.
    /// </summary>
    public enum ImageGenPartialImageEventSize
    {
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1536,
        /// <summary>
        /// 
        /// </summary>
        x1536x1024,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenPartialImageEventSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenPartialImageEventSize value)
        {
            return value switch
            {
                ImageGenPartialImageEventSize.x1024x1024 => "1024x1024",
                ImageGenPartialImageEventSize.x1024x1536 => "1024x1536",
                ImageGenPartialImageEventSize.x1536x1024 => "1536x1024",
                ImageGenPartialImageEventSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenPartialImageEventSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageGenPartialImageEventSize.x1024x1024,
                "1024x1536" => ImageGenPartialImageEventSize.x1024x1536,
                "1536x1024" => ImageGenPartialImageEventSize.x1536x1024,
                "auto" => ImageGenPartialImageEventSize.Auto,
                _ => null,
            };
        }
    }
}