
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality setting for the requested image.
    /// </summary>
    public enum ImageGenPartialImageEventQuality
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
    public static class ImageGenPartialImageEventQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenPartialImageEventQuality value)
        {
            return value switch
            {
                ImageGenPartialImageEventQuality.Low => "low",
                ImageGenPartialImageEventQuality.Medium => "medium",
                ImageGenPartialImageEventQuality.High => "high",
                ImageGenPartialImageEventQuality.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenPartialImageEventQuality? ToEnum(string value)
        {
            return value switch
            {
                "low" => ImageGenPartialImageEventQuality.Low,
                "medium" => ImageGenPartialImageEventQuality.Medium,
                "high" => ImageGenPartialImageEventQuality.High,
                "auto" => ImageGenPartialImageEventQuality.Auto,
                _ => null,
            };
        }
    }
}