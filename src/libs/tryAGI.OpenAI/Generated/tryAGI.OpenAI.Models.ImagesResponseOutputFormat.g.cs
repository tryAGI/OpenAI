
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format of the image generation. Either `png`, `webp`, or `jpeg`.
    /// </summary>
    public enum ImagesResponseOutputFormat
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
    public static class ImagesResponseOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagesResponseOutputFormat value)
        {
            return value switch
            {
                ImagesResponseOutputFormat.Png => "png",
                ImagesResponseOutputFormat.Webp => "webp",
                ImagesResponseOutputFormat.Jpeg => "jpeg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagesResponseOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => ImagesResponseOutputFormat.Png,
                "webp" => ImagesResponseOutputFormat.Webp,
                "jpeg" => ImagesResponseOutputFormat.Jpeg,
                _ => null,
            };
        }
    }
}