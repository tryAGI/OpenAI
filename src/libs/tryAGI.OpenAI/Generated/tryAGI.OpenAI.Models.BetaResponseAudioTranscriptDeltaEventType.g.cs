
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.audio.transcript.delta`.
    /// </summary>
    public enum BetaResponseAudioTranscriptDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseAudioTranscriptDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseAudioTranscriptDeltaEventType value)
        {
            return value switch
            {
                BetaResponseAudioTranscriptDeltaEventType.ResponseAudioTranscriptDelta => "response.audio.transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseAudioTranscriptDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.transcript.delta" => BetaResponseAudioTranscriptDeltaEventType.ResponseAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}