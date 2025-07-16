
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `image_edit.partial_image`.
    /// </summary>
    public enum ImageEditPartialImageEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageEditPartialImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEditPartialImageEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditPartialImageEventType value)
        {
            return value switch
            {
                ImageEditPartialImageEventType.ImageEditPartialImage => "image_edit.partial_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditPartialImageEventType? ToEnum(string value)
        {
            return value switch
            {
                "image_edit.partial_image" => ImageEditPartialImageEventType.ImageEditPartialImage,
                _ => null,
            };
        }
    }
}