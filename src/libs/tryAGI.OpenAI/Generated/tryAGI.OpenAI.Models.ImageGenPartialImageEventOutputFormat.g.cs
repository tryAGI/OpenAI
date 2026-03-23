
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format for the requested image.
    /// </summary>
    public enum ImageGenPartialImageEventOutputFormat
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
    public static class ImageGenPartialImageEventOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenPartialImageEventOutputFormat value)
        {
            return value switch
            {
                ImageGenPartialImageEventOutputFormat.Jpeg => "jpeg",
                ImageGenPartialImageEventOutputFormat.Png => "png",
                ImageGenPartialImageEventOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenPartialImageEventOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => ImageGenPartialImageEventOutputFormat.Jpeg,
                "png" => ImageGenPartialImageEventOutputFormat.Png,
                "webp" => ImageGenPartialImageEventOutputFormat.Webp,
                _ => null,
            };
        }
    }
}