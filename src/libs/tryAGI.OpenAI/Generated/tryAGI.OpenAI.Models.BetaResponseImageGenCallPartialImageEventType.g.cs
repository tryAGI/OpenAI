
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.image_generation_call.partial_image'.
    /// </summary>
    public enum BetaResponseImageGenCallPartialImageEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseImageGenerationCallPartialImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseImageGenCallPartialImageEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseImageGenCallPartialImageEventType value)
        {
            return value switch
            {
                BetaResponseImageGenCallPartialImageEventType.ResponseImageGenerationCallPartialImage => "response.image_generation_call.partial_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseImageGenCallPartialImageEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.partial_image" => BetaResponseImageGenCallPartialImageEventType.ResponseImageGenerationCallPartialImage,
                _ => null,
            };
        }
    }
}