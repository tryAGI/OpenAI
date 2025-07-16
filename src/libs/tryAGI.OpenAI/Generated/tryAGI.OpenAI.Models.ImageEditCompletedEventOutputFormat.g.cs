
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format for the edited image.
    /// </summary>
    public enum ImageEditCompletedEventOutputFormat
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
    public static class ImageEditCompletedEventOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditCompletedEventOutputFormat value)
        {
            return value switch
            {
                ImageEditCompletedEventOutputFormat.Png => "png",
                ImageEditCompletedEventOutputFormat.Webp => "webp",
                ImageEditCompletedEventOutputFormat.Jpeg => "jpeg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditCompletedEventOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => ImageEditCompletedEventOutputFormat.Png,
                "webp" => ImageEditCompletedEventOutputFormat.Webp,
                "jpeg" => ImageEditCompletedEventOutputFormat.Jpeg,
                _ => null,
            };
        }
    }
}