
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The background setting for the requested image.
    /// </summary>
    public enum ImageGenPartialImageEventBackground
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
    public static class ImageGenPartialImageEventBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenPartialImageEventBackground value)
        {
            return value switch
            {
                ImageGenPartialImageEventBackground.Transparent => "transparent",
                ImageGenPartialImageEventBackground.Opaque => "opaque",
                ImageGenPartialImageEventBackground.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenPartialImageEventBackground? ToEnum(string value)
        {
            return value switch
            {
                "transparent" => ImageGenPartialImageEventBackground.Transparent,
                "opaque" => ImageGenPartialImageEventBackground.Opaque,
                "auto" => ImageGenPartialImageEventBackground.Auto,
                _ => null,
            };
        }
    }
}