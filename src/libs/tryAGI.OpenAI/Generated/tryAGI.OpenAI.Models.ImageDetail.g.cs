
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
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
    public static class ImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageDetail value)
        {
            return value switch
            {
                ImageDetail.Low => "low",
                ImageDetail.High => "high",
                ImageDetail.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "low" => ImageDetail.Low,
                "high" => ImageDetail.High,
                "auto" => ImageDetail.Auto,
                _ => null,
            };
        }
    }
}