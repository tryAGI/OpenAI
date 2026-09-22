
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality of the generated image. The GPT image models support `low`,<br/>
    /// `medium`, and `high`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`,<br/>
    /// including their `2026-09-08` snapshots, also support `xhigh` and `max`.<br/>
    /// Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ImageGenToolQuality
    {
        /// <summary>
        /// `auto`.
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolQuality value)
        {
            return value switch
            {
                ImageGenToolQuality.Auto => "auto",
                ImageGenToolQuality.High => "high",
                ImageGenToolQuality.Low => "low",
                ImageGenToolQuality.Max => "max",
                ImageGenToolQuality.Medium => "medium",
                ImageGenToolQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenToolQuality.Auto,
                "high" => ImageGenToolQuality.High,
                "low" => ImageGenToolQuality.Low,
                "max" => ImageGenToolQuality.Max,
                "medium" => ImageGenToolQuality.Medium,
                "xhigh" => ImageGenToolQuality.Xhigh,
                _ => null,
            };
        }
    }
}