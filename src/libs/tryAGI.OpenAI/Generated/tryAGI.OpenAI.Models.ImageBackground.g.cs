
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageBackground
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
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
    public static class ImageBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageBackground value)
        {
            return value switch
            {
                ImageBackground.Auto => "auto",
                ImageBackground.Opaque => "opaque",
                ImageBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageBackground.Auto,
                "opaque" => ImageBackground.Opaque,
                "transparent" => ImageBackground.Transparent,
                _ => null,
            };
        }
    }
}