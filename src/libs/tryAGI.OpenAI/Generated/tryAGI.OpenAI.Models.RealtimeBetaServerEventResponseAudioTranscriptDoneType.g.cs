
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_audio_transcript.done`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseAudioTranscriptDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioTranscriptDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseAudioTranscriptDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseAudioTranscriptDoneType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseAudioTranscriptDoneType.ResponseOutputAudioTranscriptDone => "response.output_audio_transcript.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseAudioTranscriptDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio_transcript.done" => RealtimeBetaServerEventResponseAudioTranscriptDoneType.ResponseOutputAudioTranscriptDone,
                _ => null,
            };
        }
    }
}