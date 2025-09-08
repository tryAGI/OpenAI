
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_audio_transcript.delta`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseAudioTranscriptDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseAudioTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseAudioTranscriptDeltaType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseAudioTranscriptDeltaType.ResponseOutputAudioTranscriptDelta => "response.output_audio_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseAudioTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio_transcript.delta" => RealtimeBetaServerEventResponseAudioTranscriptDeltaType.ResponseOutputAudioTranscriptDelta,
                _ => null,
            };
        }
    }
}