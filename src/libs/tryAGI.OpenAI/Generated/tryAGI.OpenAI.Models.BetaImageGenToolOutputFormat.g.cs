
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format of the generated image. One of `png`, `webp`, or<br/>
    /// `jpeg`. Default: `png`.<br/>
    /// Default Value: png
    /// </summary>
    public enum BetaImageGenToolOutputFormat
    {
        /// <summary>
        /// `png`.
        /// </summary>
        Jpeg,
        /// <summary>
        /// `png`.
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
    public static class BetaImageGenToolOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolOutputFormat value)
        {
            return value switch
            {
                BetaImageGenToolOutputFormat.Jpeg => "jpeg",
                BetaImageGenToolOutputFormat.Png => "png",
                BetaImageGenToolOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => BetaImageGenToolOutputFormat.Jpeg,
                "png" => BetaImageGenToolOutputFormat.Png,
                "webp" => BetaImageGenToolOutputFormat.Webp,
                _ => null,
            };
        }
    }
}