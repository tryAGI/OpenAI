
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
    public static class ImageGenCompletedEventBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenCompletedEventBackground value)
        {
            return value switch
            {
                ImageGenCompletedEventBackground.Auto => "auto",
                ImageGenCompletedEventBackground.Opaque => "opaque",
                ImageGenCompletedEventBackground.Transparent => "transparent",
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
                "auto" => ImageGenCompletedEventBackground.Auto,
                "opaque" => ImageGenCompletedEventBackground.Opaque,
                "transparent" => ImageGenCompletedEventBackground.Transparent,
                _ => null,
            };
        }
    }
}