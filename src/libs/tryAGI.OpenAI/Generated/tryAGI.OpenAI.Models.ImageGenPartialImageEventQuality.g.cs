
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
    public static class ImageGenPartialImageEventQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenPartialImageEventQuality value)
        {
            return value switch
            {
                ImageGenPartialImageEventQuality.Auto => "auto",
                ImageGenPartialImageEventQuality.High => "high",
                ImageGenPartialImageEventQuality.Low => "low",
                ImageGenPartialImageEventQuality.Medium => "medium",
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
                "auto" => ImageGenPartialImageEventQuality.Auto,
                "high" => ImageGenPartialImageEventQuality.High,
                "low" => ImageGenPartialImageEventQuality.Low,
                "medium" => ImageGenPartialImageEventQuality.Medium,
                _ => null,
            };
        }
    }
}