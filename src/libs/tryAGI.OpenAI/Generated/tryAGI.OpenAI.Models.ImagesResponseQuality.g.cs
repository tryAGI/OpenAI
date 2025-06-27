
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
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
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
                ImagesResponseQuality.Low => "low",
                ImagesResponseQuality.Medium => "medium",
                ImagesResponseQuality.High => "high",
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
                "low" => ImagesResponseQuality.Low,
                "medium" => ImagesResponseQuality.Medium,
                "high" => ImagesResponseQuality.High,
                _ => null,
            };
        }
    }
}