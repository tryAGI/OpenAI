
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `image_generation.partial_image`.
    /// </summary>
    public enum ImageGenPartialImageEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGenerationPartialImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenPartialImageEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenPartialImageEventType value)
        {
            return value switch
            {
                ImageGenPartialImageEventType.ImageGenerationPartialImage => "image_generation.partial_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenPartialImageEventType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation.partial_image" => ImageGenPartialImageEventType.ImageGenerationPartialImage,
                _ => null,
            };
        }
    }
}