
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
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