
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality of the image generated. One of `low`, `medium`, `high`, `xhigh`, or `max`.
    /// </summary>
    public enum ImagesResponseQuality
    {
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
    public static class ImagesResponseQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagesResponseQuality value)
        {
            return value switch
            {
                ImagesResponseQuality.High => "high",
                ImagesResponseQuality.Low => "low",
                ImagesResponseQuality.Max => "max",
                ImagesResponseQuality.Medium => "medium",
                ImagesResponseQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagesResponseQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => ImagesResponseQuality.High,
                "low" => ImagesResponseQuality.Low,
                "max" => ImagesResponseQuality.Max,
                "medium" => ImagesResponseQuality.Medium,
                "xhigh" => ImagesResponseQuality.Xhigh,
                _ => null,
            };
        }
    }
}