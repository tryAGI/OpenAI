
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality setting for the generated image.
    /// </summary>
    public enum ImageGenCompletedEventQuality
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
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenCompletedEventQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenCompletedEventQuality value)
        {
            return value switch
            {
                ImageGenCompletedEventQuality.Low => "low",
                ImageGenCompletedEventQuality.Medium => "medium",
                ImageGenCompletedEventQuality.High => "high",
                ImageGenCompletedEventQuality.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenCompletedEventQuality? ToEnum(string value)
        {
            return value switch
            {
                "low" => ImageGenCompletedEventQuality.Low,
                "medium" => ImageGenCompletedEventQuality.Medium,
                "high" => ImageGenCompletedEventQuality.High,
                "auto" => ImageGenCompletedEventQuality.Auto,
                _ => null,
            };
        }
    }
}