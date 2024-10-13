
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.audio_transcript.done".<br/>
    /// Example: response.audio_transcript.done
    /// </summary>
    public enum RealtimeResponseAudioTranscriptDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioTranscriptDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseAudioTranscriptDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseAudioTranscriptDoneType value)
        {
            return value switch
            {
                RealtimeResponseAudioTranscriptDoneType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseAudioTranscriptDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio_transcript.done" => RealtimeResponseAudioTranscriptDoneType.ResponseAudioTranscriptDone,
                _ => null,
            };
        }
    }
}