
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality of the image generated. Either `low`, `medium`, or `high`.
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
        Medium,
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
                ImagesResponseQuality.Medium => "medium",
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
                "medium" => ImagesResponseQuality.Medium,
                _ => null,
            };
        }
    }
}