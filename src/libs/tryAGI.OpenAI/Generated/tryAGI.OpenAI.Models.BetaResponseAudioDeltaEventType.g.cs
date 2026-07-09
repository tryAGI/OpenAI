
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.audio.delta`.
    /// </summary>
    public enum BetaResponseAudioDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseAudioDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseAudioDeltaEventType value)
        {
            return value switch
            {
                BetaResponseAudioDeltaEventType.ResponseAudioDelta => "response.audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseAudioDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.delta" => BetaResponseAudioDeltaEventType.ResponseAudioDelta,
                _ => null,
            };
        }
    }
}