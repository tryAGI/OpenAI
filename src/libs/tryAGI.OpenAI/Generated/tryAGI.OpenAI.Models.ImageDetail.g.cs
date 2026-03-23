
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
        Original,
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
                ImageDetail.Auto => "auto",
                ImageDetail.High => "high",
                ImageDetail.Low => "low",
                ImageDetail.Original => "original",
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
                "auto" => ImageDetail.Auto,
                "high" => ImageDetail.High,
                "low" => ImageDetail.Low,
                "original" => ImageDetail.Original,
                _ => null,
            };
        }
    }
}