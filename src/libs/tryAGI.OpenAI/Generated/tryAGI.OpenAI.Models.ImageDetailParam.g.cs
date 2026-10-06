
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageDetailParam
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
    public static class ImageDetailParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageDetailParam value)
        {
            return value switch
            {
                ImageDetailParam.Auto => "auto",
                ImageDetailParam.High => "high",
                ImageDetailParam.Low => "low",
                ImageDetailParam.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageDetailParam? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageDetailParam.Auto,
                "high" => ImageDetailParam.High,
                "low" => ImageDetailParam.Low,
                "original" => ImageDetailParam.Original,
                _ => null,
            };
        }
    }
}