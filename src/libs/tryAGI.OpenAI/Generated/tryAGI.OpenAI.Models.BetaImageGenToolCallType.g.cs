
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the image generation call. Always `image_generation_call`.
    /// </summary>
    public enum BetaImageGenToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGenerationCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolCallType value)
        {
            return value switch
            {
                BetaImageGenToolCallType.ImageGenerationCall => "image_generation_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation_call" => BetaImageGenToolCallType.ImageGenerationCall,
                _ => null,
            };
        }
    }
}