
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ImageGenToolCallSizeVariant1
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
    public static class ImageGenToolCallSizeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolCallSizeVariant1 value)
        {
            return value switch
            {
                ImageGenToolCallSizeVariant1.x1024x1024 => "1024x1024",
                ImageGenToolCallSizeVariant1.x1024x1536 => "1024x1536",
                ImageGenToolCallSizeVariant1.x1536x1024 => "1536x1024",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolCallSizeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageGenToolCallSizeVariant1.x1024x1024,
                "1024x1536" => ImageGenToolCallSizeVariant1.x1024x1536,
                "1536x1024" => ImageGenToolCallSizeVariant1.x1536x1024,
                _ => null,
            };
        }
    }
}