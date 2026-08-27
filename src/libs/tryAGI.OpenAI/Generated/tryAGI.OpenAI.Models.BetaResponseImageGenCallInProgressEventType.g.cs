
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.image_generation_call.in_progress'.
    /// </summary>
    public enum BetaResponseImageGenCallInProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseImageGenCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseImageGenCallInProgressEventType value)
        {
            return value switch
            {
                BetaResponseImageGenCallInProgressEventType.ResponseImageGenerationCallInProgress => "response.image_generation_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseImageGenCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.image_generation_call.in_progress" => BetaResponseImageGenCallInProgressEventType.ResponseImageGenerationCallInProgress,
                _ => null,
            };
        }
    }
}