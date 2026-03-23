
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The background parameter used for the image generation. Either `transparent` or `opaque`.
    /// </summary>
    public enum ImagesResponseBackground
    {
        /// <summary>
        /// 
        /// </summary>
        Opaque,
        /// <summary>
        /// 
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImagesResponseBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagesResponseBackground value)
        {
            return value switch
            {
                ImagesResponseBackground.Opaque => "opaque",
                ImagesResponseBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagesResponseBackground? ToEnum(string value)
        {
            return value switch
            {
                "opaque" => ImagesResponseBackground.Opaque,
                "transparent" => ImagesResponseBackground.Transparent,
                _ => null,
            };
        }
    }
}