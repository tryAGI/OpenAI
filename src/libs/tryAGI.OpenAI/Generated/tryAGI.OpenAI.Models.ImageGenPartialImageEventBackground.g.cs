
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
    public static class ImageGenPartialImageEventBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenPartialImageEventBackground value)
        {
            return value switch
            {
                ImageGenPartialImageEventBackground.Auto => "auto",
                ImageGenPartialImageEventBackground.Opaque => "opaque",
                ImageGenPartialImageEventBackground.Transparent => "transparent",
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
                "auto" => ImageGenPartialImageEventBackground.Auto,
                "opaque" => ImageGenPartialImageEventBackground.Opaque,
                "transparent" => ImageGenPartialImageEventBackground.Transparent,
                _ => null,
            };
        }
    }
}