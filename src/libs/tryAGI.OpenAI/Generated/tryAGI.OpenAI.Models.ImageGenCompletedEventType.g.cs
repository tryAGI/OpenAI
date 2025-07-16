
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `image_generation.completed`.
    /// </summary>
    public enum ImageGenCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGenerationCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenCompletedEventType value)
        {
            return value switch
            {
                ImageGenCompletedEventType.ImageGenerationCompleted => "image_generation.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation.completed" => ImageGenCompletedEventType.ImageGenerationCompleted,
                _ => null,
            };
        }
    }
}