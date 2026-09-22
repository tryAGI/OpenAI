
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality of the image that will be generated for GPT image models. The GPT image models support `low`, `medium`, and `high`. `gpt-image-2.5-sunburst` and `gpt-image-2.5-flare`, including their `2026-09-08` snapshots, also support `xhigh` and `max`. Defaults to `auto`.<br/>
    /// Default Value: auto<br/>
    /// Example: high
    /// </summary>
    public enum CreateImageEditRequestQuality
    {
        /// <summary>
        ///
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
        Standard,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestQuality value)
        {
            return value switch
            {
                CreateImageEditRequestQuality.Auto => "auto",
                CreateImageEditRequestQuality.High => "high",
                CreateImageEditRequestQuality.Low => "low",
                CreateImageEditRequestQuality.Max => "max",
                CreateImageEditRequestQuality.Medium => "medium",
                CreateImageEditRequestQuality.Standard => "standard",
                CreateImageEditRequestQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateImageEditRequestQuality.Auto,
                "high" => CreateImageEditRequestQuality.High,
                "low" => CreateImageEditRequestQuality.Low,
                "max" => CreateImageEditRequestQuality.Max,
                "medium" => CreateImageEditRequestQuality.Medium,
                "standard" => CreateImageEditRequestQuality.Standard,
                "xhigh" => CreateImageEditRequestQuality.Xhigh,
                _ => null,
            };
        }
    }
}