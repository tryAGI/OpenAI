
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
        Gif,
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
        Svg,
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
                BetaImageOutputFormat.Gif => "gif",
                BetaImageOutputFormat.Jpeg => "jpeg",
                BetaImageOutputFormat.Png => "png",
                BetaImageOutputFormat.Svg => "svg",
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
                "gif" => BetaImageOutputFormat.Gif,
                "jpeg" => BetaImageOutputFormat.Jpeg,
                "png" => BetaImageOutputFormat.Png,
                "svg" => BetaImageOutputFormat.Svg,
                "webp" => BetaImageOutputFormat.Webp,
                _ => null,
            };
        }
    }
}