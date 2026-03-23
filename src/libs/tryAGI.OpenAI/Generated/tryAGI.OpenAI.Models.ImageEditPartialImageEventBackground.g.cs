
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
    public static class ImageEditPartialImageEventBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditPartialImageEventBackground value)
        {
            return value switch
            {
                ImageEditPartialImageEventBackground.Auto => "auto",
                ImageEditPartialImageEventBackground.Opaque => "opaque",
                ImageEditPartialImageEventBackground.Transparent => "transparent",
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
                "auto" => ImageEditPartialImageEventBackground.Auto,
                "opaque" => ImageEditPartialImageEventBackground.Opaque,
                "transparent" => ImageEditPartialImageEventBackground.Transparent,
                _ => null,
            };
        }
    }
}