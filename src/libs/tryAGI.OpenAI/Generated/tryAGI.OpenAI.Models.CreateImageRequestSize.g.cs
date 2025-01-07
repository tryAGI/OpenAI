
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.<br/>
    /// Default Value: 1024x1024<br/>
    /// Example: 1024x1024
    /// </summary>
    public enum CreateImageRequestSize
    {
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
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x1792x1024,
        /// <summary>
        /// 
        /// </summary>
        x1024x1792,
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
                CreateImageRequestSize.x256x256 => "256x256",
                CreateImageRequestSize.x512x512 => "512x512",
                CreateImageRequestSize.x1024x1024 => "1024x1024",
                CreateImageRequestSize.x1792x1024 => "1792x1024",
                CreateImageRequestSize.x1024x1792 => "1024x1792",
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
                "256x256" => CreateImageRequestSize.x256x256,
                "512x512" => CreateImageRequestSize.x512x512,
                "1024x1024" => CreateImageRequestSize.x1024x1024,
                "1792x1024" => CreateImageRequestSize.x1792x1024,
                "1024x1792" => CreateImageRequestSize.x1024x1792,
                _ => null,
            };
        }
    }
}