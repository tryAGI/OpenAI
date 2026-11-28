
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageContextCompression
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageContextCompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageContextCompression value)
        {
            return value switch
            {
                ImageContextCompression.Auto => "auto",
                ImageContextCompression.Disabled => "disabled",
                ImageContextCompression.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageContextCompression? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageContextCompression.Auto,
                "disabled" => ImageContextCompression.Disabled,
                "enabled" => ImageContextCompression.Enabled,
                _ => null,
            };
        }
    }
}