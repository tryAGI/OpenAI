
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format for the generated image.
    /// </summary>
    public enum ImageGenCompletedEventOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenCompletedEventOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenCompletedEventOutputFormat value)
        {
            return value switch
            {
                ImageGenCompletedEventOutputFormat.Png => "png",
                ImageGenCompletedEventOutputFormat.Webp => "webp",
                ImageGenCompletedEventOutputFormat.Jpeg => "jpeg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenCompletedEventOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => ImageGenCompletedEventOutputFormat.Png,
                "webp" => ImageGenCompletedEventOutputFormat.Webp,
                "jpeg" => ImageGenCompletedEventOutputFormat.Jpeg,
                _ => null,
            };
        }
    }
}