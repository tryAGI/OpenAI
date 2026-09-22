
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
    public enum BetaImageGenToolQuality
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
    public static class BetaImageGenToolQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolQuality value)
        {
            return value switch
            {
                BetaImageGenToolQuality.Auto => "auto",
                BetaImageGenToolQuality.High => "high",
                BetaImageGenToolQuality.Low => "low",
                BetaImageGenToolQuality.Max => "max",
                BetaImageGenToolQuality.Medium => "medium",
                BetaImageGenToolQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaImageGenToolQuality.Auto,
                "high" => BetaImageGenToolQuality.High,
                "low" => BetaImageGenToolQuality.Low,
                "max" => BetaImageGenToolQuality.Max,
                "medium" => BetaImageGenToolQuality.Medium,
                "xhigh" => BetaImageGenToolQuality.Xhigh,
                _ => null,
            };
        }
    }
}