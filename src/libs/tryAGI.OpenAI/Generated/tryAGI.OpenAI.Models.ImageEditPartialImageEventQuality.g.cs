
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality setting for the requested edited image.
    /// </summary>
    public enum ImageEditPartialImageEventQuality
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
    public static class ImageEditPartialImageEventQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditPartialImageEventQuality value)
        {
            return value switch
            {
                ImageEditPartialImageEventQuality.Low => "low",
                ImageEditPartialImageEventQuality.Medium => "medium",
                ImageEditPartialImageEventQuality.High => "high",
                ImageEditPartialImageEventQuality.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditPartialImageEventQuality? ToEnum(string value)
        {
            return value switch
            {
                "low" => ImageEditPartialImageEventQuality.Low,
                "medium" => ImageEditPartialImageEventQuality.Medium,
                "high" => ImageEditPartialImageEventQuality.High,
                "auto" => ImageEditPartialImageEventQuality.Auto,
                _ => null,
            };
        }
    }
}