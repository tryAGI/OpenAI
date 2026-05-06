
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageEditRequestSize
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
    public static class CreateImageEditRequestSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestSize value)
        {
            return value switch
            {
                CreateImageEditRequestSize.x1024x1024 => "1024x1024",
                CreateImageEditRequestSize.x1024x1536 => "1024x1536",
                CreateImageEditRequestSize.x1536x1024 => "1536x1024",
                CreateImageEditRequestSize.x256x256 => "256x256",
                CreateImageEditRequestSize.x512x512 => "512x512",
                CreateImageEditRequestSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => CreateImageEditRequestSize.x1024x1024,
                "1024x1536" => CreateImageEditRequestSize.x1024x1536,
                "1536x1024" => CreateImageEditRequestSize.x1536x1024,
                "256x256" => CreateImageEditRequestSize.x256x256,
                "512x512" => CreateImageEditRequestSize.x512x512,
                "auto" => CreateImageEditRequestSize.Auto,
                _ => null,
            };
        }
    }
}