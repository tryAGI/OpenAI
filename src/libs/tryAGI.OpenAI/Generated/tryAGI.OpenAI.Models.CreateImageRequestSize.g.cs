
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageRequestSize
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
        x1024x1792,
        /// <summary>
        /// 
        /// </summary>
        x1536x1024,
        /// <summary>
        /// 
        /// </summary>
        x1792x1024,
        /// <summary>
        /// 
        /// </summary>
        x256x256,
        /// <summary>
        /// 
        /// </summary>
        x512x512,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestSize value)
        {
            return value switch
            {
                CreateImageRequestSize.x1024x1024 => "1024x1024",
                CreateImageRequestSize.x1024x1536 => "1024x1536",
                CreateImageRequestSize.x1024x1792 => "1024x1792",
                CreateImageRequestSize.x1536x1024 => "1536x1024",
                CreateImageRequestSize.x1792x1024 => "1792x1024",
                CreateImageRequestSize.x256x256 => "256x256",
                CreateImageRequestSize.x512x512 => "512x512",
                CreateImageRequestSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => CreateImageRequestSize.x1024x1024,
                "1024x1536" => CreateImageRequestSize.x1024x1536,
                "1024x1792" => CreateImageRequestSize.x1024x1792,
                "1536x1024" => CreateImageRequestSize.x1536x1024,
                "1792x1024" => CreateImageRequestSize.x1792x1024,
                "256x256" => CreateImageRequestSize.x256x256,
                "512x512" => CreateImageRequestSize.x512x512,
                "auto" => CreateImageRequestSize.Auto,
                _ => null,
            };
        }
    }
}