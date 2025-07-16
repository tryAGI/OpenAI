
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The background setting for the edited image.
    /// </summary>
    public enum ImageEditCompletedEventBackground
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
    public static class ImageEditCompletedEventBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditCompletedEventBackground value)
        {
            return value switch
            {
                ImageEditCompletedEventBackground.Transparent => "transparent",
                ImageEditCompletedEventBackground.Opaque => "opaque",
                ImageEditCompletedEventBackground.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditCompletedEventBackground? ToEnum(string value)
        {
            return value switch
            {
                "transparent" => ImageEditCompletedEventBackground.Transparent,
                "opaque" => ImageEditCompletedEventBackground.Opaque,
                "auto" => ImageEditCompletedEventBackground.Auto,
                _ => null,
            };
        }
    }
}