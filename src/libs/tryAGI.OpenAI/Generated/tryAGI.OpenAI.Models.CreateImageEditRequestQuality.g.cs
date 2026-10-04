
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
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