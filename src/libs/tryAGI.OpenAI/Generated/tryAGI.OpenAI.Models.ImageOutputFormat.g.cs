
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Gif,
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
        /// <summary>
        ///
        /// </summary>
        Svg,
        /// <summary>
        ///
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageOutputFormat value)
        {
            return value switch
            {
                ImageOutputFormat.Gif => "gif",
                ImageOutputFormat.Jpeg => "jpeg",
                ImageOutputFormat.Png => "png",
                ImageOutputFormat.Svg => "svg",
                ImageOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => ImageOutputFormat.Gif,
                "jpeg" => ImageOutputFormat.Jpeg,
                "png" => ImageOutputFormat.Png,
                "svg" => ImageOutputFormat.Svg,
                "webp" => ImageOutputFormat.Webp,
                _ => null,
            };
        }
    }
}