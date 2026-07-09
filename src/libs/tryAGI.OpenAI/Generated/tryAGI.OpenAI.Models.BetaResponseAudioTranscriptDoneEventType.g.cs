
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.audio.transcript.done`.
    /// </summary>
    public enum BetaResponseAudioTranscriptDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioTranscriptDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseAudioTranscriptDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseAudioTranscriptDoneEventType value)
        {
            return value switch
            {
                BetaResponseAudioTranscriptDoneEventType.ResponseAudioTranscriptDone => "response.audio.transcript.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseAudioTranscriptDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.transcript.done" => BetaResponseAudioTranscriptDoneEventType.ResponseAudioTranscriptDone,
                _ => null,
            };
        }
    }
}