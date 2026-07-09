
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality of the generated image. One of `low`, `medium`, `high`,<br/>
    /// or `auto`. Default: `auto`.<br/>
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
        Medium,
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
                BetaImageGenToolQuality.Medium => "medium",
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
                "medium" => BetaImageGenToolQuality.Medium,
                _ => null,
            };
        }
    }
}