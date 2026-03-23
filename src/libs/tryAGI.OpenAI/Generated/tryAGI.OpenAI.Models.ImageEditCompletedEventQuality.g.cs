
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
    public static class ImageEditCompletedEventQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditCompletedEventQuality value)
        {
            return value switch
            {
                ImageEditCompletedEventQuality.Auto => "auto",
                ImageEditCompletedEventQuality.High => "high",
                ImageEditCompletedEventQuality.Low => "low",
                ImageEditCompletedEventQuality.Medium => "medium",
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
                "auto" => ImageEditCompletedEventQuality.Auto,
                "high" => ImageEditCompletedEventQuality.High,
                "low" => ImageEditCompletedEventQuality.Low,
                "medium" => ImageEditCompletedEventQuality.Medium,
                _ => null,
            };
        }
    }
}