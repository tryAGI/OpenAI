
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The size of the generated image.
    /// </summary>
    public enum ImageGenCompletedEventSize
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
    public static class ImageGenCompletedEventSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenCompletedEventSize value)
        {
            return value switch
            {
                ImageGenCompletedEventSize.x1024x1024 => "1024x1024",
                ImageGenCompletedEventSize.x1024x1536 => "1024x1536",
                ImageGenCompletedEventSize.x1536x1024 => "1536x1024",
                ImageGenCompletedEventSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenCompletedEventSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageGenCompletedEventSize.x1024x1024,
                "1024x1536" => ImageGenCompletedEventSize.x1024x1536,
                "1536x1024" => ImageGenCompletedEventSize.x1536x1024,
                "auto" => ImageGenCompletedEventSize.Auto,
                _ => null,
            };
        }
    }
}