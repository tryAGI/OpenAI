
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaImageOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        ///
        /// </summary>
        Png,
        /// <summary>
        ///
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageOutputFormat value)
        {
            return value switch
            {
                BetaImageOutputFormat.Jpeg => "jpeg",
                BetaImageOutputFormat.Png => "png",
                BetaImageOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => BetaImageOutputFormat.Jpeg,
                "png" => BetaImageOutputFormat.Png,
                "webp" => BetaImageOutputFormat.Webp,
                _ => null,
            };
        }
    }
}