
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The output format of the generated image. One of `png`, `webp`, `jpeg`,<br/>
    /// `gif`, or `svg`. Default: `png`. GIF and SVG output require a model<br/>
    /// that supports the selected format. GIF output does not support<br/>
    /// partial image streaming (`partial_images` greater than `0`),<br/>
    /// `input_image_mask`, or custom `output_compression`.<br/>
    /// Responses lifecycle events can still be streamed for GIF output.<br/>
    /// Default Value: png
    /// </summary>
    public enum BetaImageGenToolOutputFormat
    {
        /// <summary>
        /// `png`. GIF and SVG output require a model
        /// </summary>
        Gif,
        /// <summary>
        ///
        /// </summary>
        Jpeg,
        /// <summary>
        /// `png`. GIF and SVG output require a model
        /// </summary>
        Png,
        /// <summary>
        /// `png`. GIF and SVG output require a model
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
    public static class BetaImageGenToolOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolOutputFormat value)
        {
            return value switch
            {
                BetaImageGenToolOutputFormat.Gif => "gif",
                BetaImageGenToolOutputFormat.Jpeg => "jpeg",
                BetaImageGenToolOutputFormat.Png => "png",
                BetaImageGenToolOutputFormat.Svg => "svg",
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
                "gif" => BetaImageGenToolOutputFormat.Gif,
                "jpeg" => BetaImageGenToolOutputFormat.Jpeg,
                "png" => BetaImageGenToolOutputFormat.Png,
                "svg" => BetaImageGenToolOutputFormat.Svg,
                "webp" => BetaImageGenToolOutputFormat.Webp,
                _ => null,
            };
        }
    }
}