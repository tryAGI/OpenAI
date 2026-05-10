
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageEditStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageEditCompleted,
        /// <summary>
        /// 
        /// </summary>
        ImageEditPartialImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEditStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditStreamEventDiscriminatorType value)
        {
            return value switch
            {
                ImageEditStreamEventDiscriminatorType.ImageEditCompleted => "image_edit.completed",
                ImageEditStreamEventDiscriminatorType.ImageEditPartialImage => "image_edit.partial_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_edit.completed" => ImageEditStreamEventDiscriminatorType.ImageEditCompleted,
                "image_edit.partial_image" => ImageEditStreamEventDiscriminatorType.ImageEditPartialImage,
                _ => null,
            };
        }
    }
}