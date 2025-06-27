
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The size of the image generated. Either `1024x1024`, `1024x1536`, or `1536x1024`.
    /// </summary>
    public enum ImagesResponseSize
    {
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1536,
        /// <summary>
        /// 
        /// </summary>
        x1536x1024,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImagesResponseSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagesResponseSize value)
        {
            return value switch
            {
                ImagesResponseSize.x1024x1024 => "1024x1024",
                ImagesResponseSize.x1024x1536 => "1024x1536",
                ImagesResponseSize.x1536x1024 => "1536x1024",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagesResponseSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImagesResponseSize.x1024x1024,
                "1024x1536" => ImagesResponseSize.x1024x1536,
                "1536x1024" => ImagesResponseSize.x1536x1024,
                _ => null,
            };
        }
    }
}