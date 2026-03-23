
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
    public static class ImageEditPartialImageEventQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditPartialImageEventQuality value)
        {
            return value switch
            {
                ImageEditPartialImageEventQuality.Auto => "auto",
                ImageEditPartialImageEventQuality.High => "high",
                ImageEditPartialImageEventQuality.Low => "low",
                ImageEditPartialImageEventQuality.Medium => "medium",
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
                "auto" => ImageEditPartialImageEventQuality.Auto,
                "high" => ImageEditPartialImageEventQuality.High,
                "low" => ImageEditPartialImageEventQuality.Low,
                "medium" => ImageEditPartialImageEventQuality.Medium,
                _ => null,
            };
        }
    }
}