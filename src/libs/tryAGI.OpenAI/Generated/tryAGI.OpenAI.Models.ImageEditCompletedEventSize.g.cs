
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The size of the edited image.
    /// </summary>
    public enum ImageEditCompletedEventSize
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
    public static class ImageEditCompletedEventSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditCompletedEventSize value)
        {
            return value switch
            {
                ImageEditCompletedEventSize.x1024x1024 => "1024x1024",
                ImageEditCompletedEventSize.x1024x1536 => "1024x1536",
                ImageEditCompletedEventSize.x1536x1024 => "1536x1024",
                ImageEditCompletedEventSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditCompletedEventSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageEditCompletedEventSize.x1024x1024,
                "1024x1536" => ImageEditCompletedEventSize.x1024x1536,
                "1536x1024" => ImageEditCompletedEventSize.x1536x1024,
                "auto" => ImageEditCompletedEventSize.Auto,
                _ => null,
            };
        }
    }
}