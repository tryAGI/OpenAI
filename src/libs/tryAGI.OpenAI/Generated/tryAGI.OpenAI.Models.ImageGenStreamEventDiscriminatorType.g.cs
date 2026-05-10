
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGenerationCompleted,
        /// <summary>
        /// 
        /// </summary>
        ImageGenerationPartialImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenStreamEventDiscriminatorType value)
        {
            return value switch
            {
                ImageGenStreamEventDiscriminatorType.ImageGenerationCompleted => "image_generation.completed",
                ImageGenStreamEventDiscriminatorType.ImageGenerationPartialImage => "image_generation.partial_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation.completed" => ImageGenStreamEventDiscriminatorType.ImageGenerationCompleted,
                "image_generation.partial_image" => ImageGenStreamEventDiscriminatorType.ImageGenerationPartialImage,
                _ => null,
            };
        }
    }
}