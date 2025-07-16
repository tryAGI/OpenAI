
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `image_edit.completed`.
    /// </summary>
    public enum ImageEditCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageEditCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEditCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditCompletedEventType value)
        {
            return value switch
            {
                ImageEditCompletedEventType.ImageEditCompleted => "image_edit.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "image_edit.completed" => ImageEditCompletedEventType.ImageEditCompleted,
                _ => null,
            };
        }
    }
}