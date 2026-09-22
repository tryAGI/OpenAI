
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
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
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
                ImageOutputFormat.Jpeg => "jpeg",
                ImageOutputFormat.Png => "png",
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
                "jpeg" => ImageOutputFormat.Jpeg,
                "png" => ImageOutputFormat.Png,
                "webp" => ImageOutputFormat.Webp,
                _ => null,
            };
        }
    }
}