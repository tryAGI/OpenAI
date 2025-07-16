
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The background setting for the requested edited image.
    /// </summary>
    public enum ImageEditPartialImageEventBackground
    {
        /// <summary>
        /// 
        /// </summary>
        Transparent,
        /// <summary>
        /// 
        /// </summary>
        Opaque,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEditPartialImageEventBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditPartialImageEventBackground value)
        {
            return value switch
            {
                ImageEditPartialImageEventBackground.Transparent => "transparent",
                ImageEditPartialImageEventBackground.Opaque => "opaque",
                ImageEditPartialImageEventBackground.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditPartialImageEventBackground? ToEnum(string value)
        {
            return value switch
            {
                "transparent" => ImageEditPartialImageEventBackground.Transparent,
                "opaque" => ImageEditPartialImageEventBackground.Opaque,
                "auto" => ImageEditPartialImageEventBackground.Auto,
                _ => null,
            };
        }
    }
}