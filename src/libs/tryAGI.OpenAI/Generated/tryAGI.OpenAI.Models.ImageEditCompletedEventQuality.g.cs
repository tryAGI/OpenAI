
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality setting for the edited image.
    /// </summary>
    public enum ImageEditCompletedEventQuality
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
    public static class ImageEditCompletedEventQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditCompletedEventQuality value)
        {
            return value switch
            {
                ImageEditCompletedEventQuality.Low => "low",
                ImageEditCompletedEventQuality.Medium => "medium",
                ImageEditCompletedEventQuality.High => "high",
                ImageEditCompletedEventQuality.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditCompletedEventQuality? ToEnum(string value)
        {
            return value switch
            {
                "low" => ImageEditCompletedEventQuality.Low,
                "medium" => ImageEditCompletedEventQuality.Medium,
                "high" => ImageEditCompletedEventQuality.High,
                "auto" => ImageEditCompletedEventQuality.Auto,
                _ => null,
            };
        }
    }
}