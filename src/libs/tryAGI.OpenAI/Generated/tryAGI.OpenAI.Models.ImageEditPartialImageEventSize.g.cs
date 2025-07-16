
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The size of the requested edited image.
    /// </summary>
    public enum ImageEditPartialImageEventSize
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
    public static class ImageEditPartialImageEventSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditPartialImageEventSize value)
        {
            return value switch
            {
                ImageEditPartialImageEventSize.x1024x1024 => "1024x1024",
                ImageEditPartialImageEventSize.x1024x1536 => "1024x1536",
                ImageEditPartialImageEventSize.x1536x1024 => "1536x1024",
                ImageEditPartialImageEventSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditPartialImageEventSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageEditPartialImageEventSize.x1024x1024,
                "1024x1536" => ImageEditPartialImageEventSize.x1024x1536,
                "1536x1024" => ImageEditPartialImageEventSize.x1536x1024,
                "auto" => ImageEditPartialImageEventSize.Auto,
                _ => null,
            };
        }
    }
}