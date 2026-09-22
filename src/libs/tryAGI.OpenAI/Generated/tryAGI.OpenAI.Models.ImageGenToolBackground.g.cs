
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Set the background of the generated image. One of `transparent`, `opaque`,<br/>
    /// or `auto`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including<br/>
    /// their `2026-09-08` snapshots, support `opaque` and `transparent`<br/>
    /// backgrounds. Transparent backgrounds are available for supported GPT Image<br/>
    /// models. For `gpt-image-2` and `gpt-image-2-2026-04-21`, this support is in<br/>
    /// preview. When using `transparent`, set the output format to `png` or `webp`.<br/>
    /// Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ImageGenToolBackground
    {
        /// <summary>
        /// `auto`.
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
    public static class ImageGenToolBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolBackground value)
        {
            return value switch
            {
                ImageGenToolBackground.Auto => "auto",
                ImageGenToolBackground.Opaque => "opaque",
                ImageGenToolBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenToolBackground.Auto,
                "opaque" => ImageGenToolBackground.Opaque,
                "transparent" => ImageGenToolBackground.Transparent,
                _ => null,
            };
        }
    }
}