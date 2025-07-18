
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.image_generation_call.completed'.
    /// </summary>
    public enum ResponseImageGenCallCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseImageGenerationCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseImageGenCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseImageGenCallCompletedEventType value)
        {
            return value switch
            {
                ResponseImageGenCallCompletedEventType.ResponseImageGenerationCallCompleted => "response.image_generation_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseImageGenCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.completed" => ResponseImageGenCallCompletedEventType.ResponseImageGenerationCallCompleted,
                _ => null,
            };
        }
    }
}