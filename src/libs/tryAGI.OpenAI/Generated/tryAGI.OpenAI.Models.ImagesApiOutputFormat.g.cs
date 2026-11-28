
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ImagesApiOutputFormat
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
    public static class ImagesApiOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagesApiOutputFormat value)
        {
            return value switch
            {
                ImagesApiOutputFormat.Gif => "gif",
                ImagesApiOutputFormat.Jpeg => "jpeg",
                ImagesApiOutputFormat.Png => "png",
                ImagesApiOutputFormat.Svg => "svg",
                ImagesApiOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagesApiOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "gif" => ImagesApiOutputFormat.Gif,
                "jpeg" => ImagesApiOutputFormat.Jpeg,
                "png" => ImagesApiOutputFormat.Png,
                "svg" => ImagesApiOutputFormat.Svg,
                "webp" => ImagesApiOutputFormat.Webp,
                _ => null,
            };
        }
    }
}