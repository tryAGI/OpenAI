
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The background setting for the generated image.
    /// </summary>
    public enum ImageGenCompletedEventBackground
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
    public static class ImageGenCompletedEventBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenCompletedEventBackground value)
        {
            return value switch
            {
                ImageGenCompletedEventBackground.Transparent => "transparent",
                ImageGenCompletedEventBackground.Opaque => "opaque",
                ImageGenCompletedEventBackground.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenCompletedEventBackground? ToEnum(string value)
        {
            return value switch
            {
                "transparent" => ImageGenCompletedEventBackground.Transparent,
                "opaque" => ImageGenCompletedEventBackground.Opaque,
                "auto" => ImageGenCompletedEventBackground.Auto,
                _ => null,
            };
        }
    }
}