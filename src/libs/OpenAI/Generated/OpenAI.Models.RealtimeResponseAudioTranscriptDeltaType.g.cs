
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.audio_transcript.delta".<br/>
    /// Example: response.audio_transcript.delta
    /// </summary>
    public enum RealtimeResponseAudioTranscriptDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseAudioTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseAudioTranscriptDeltaType value)
        {
            return value switch
            {
                RealtimeResponseAudioTranscriptDeltaType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseAudioTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio_transcript.delta" => RealtimeResponseAudioTranscriptDeltaType.ResponseAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}