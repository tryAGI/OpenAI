
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality of the image that will be generated.<br/>
    /// - `auto` (default value) will automatically select the best quality for the given<br/>
    ///   model.<br/>
    /// - `high`, `medium` and `low` are supported for the GPT image models.<br/>
    /// - `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08`<br/>
    ///   snapshots, also support `xhigh` and `max`.<br/>
    /// - `hd` and `standard` are supported for `dall-e-3`.<br/>
    /// - `standard` is the only option for `dall-e-2`.<br/>
    /// Default Value: auto<br/>
    /// Example: medium
    /// </summary>
    public enum CreateImageRequestQuality
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Hd,
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
        Standard,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestQuality value)
        {
            return value switch
            {
                CreateImageRequestQuality.Auto => "auto",
                CreateImageRequestQuality.Hd => "hd",
                CreateImageRequestQuality.High => "high",
                CreateImageRequestQuality.Low => "low",
                CreateImageRequestQuality.Max => "max",
                CreateImageRequestQuality.Medium => "medium",
                CreateImageRequestQuality.Standard => "standard",
                CreateImageRequestQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageRequestQuality.Auto,
                "hd" => CreateImageRequestQuality.Hd,
                "high" => CreateImageRequestQuality.High,
                "low" => CreateImageRequestQuality.Low,
                "max" => CreateImageRequestQuality.Max,
                "medium" => CreateImageRequestQuality.Medium,
                "standard" => CreateImageRequestQuality.Standard,
                "xhigh" => CreateImageRequestQuality.Xhigh,
                _ => null,
            };
        }
    }
}