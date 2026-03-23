
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format for the requested edited image.
    /// </summary>
    public enum ImageEditPartialImageEventOutputFormat
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
    public static class ImageEditPartialImageEventOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditPartialImageEventOutputFormat value)
        {
            return value switch
            {
                ImageEditPartialImageEventOutputFormat.Jpeg => "jpeg",
                ImageEditPartialImageEventOutputFormat.Png => "png",
                ImageEditPartialImageEventOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditPartialImageEventOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => ImageEditPartialImageEventOutputFormat.Jpeg,
                "png" => ImageEditPartialImageEventOutputFormat.Png,
                "webp" => ImageEditPartialImageEventOutputFormat.Webp,
                _ => null,
            };
        }
    }
}