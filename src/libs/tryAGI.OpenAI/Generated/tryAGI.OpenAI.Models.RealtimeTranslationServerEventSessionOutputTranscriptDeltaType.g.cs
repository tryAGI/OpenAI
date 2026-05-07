
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.output_transcript.delta`.
    /// </summary>
    public enum RealtimeTranslationServerEventSessionOutputTranscriptDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionOutputTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationServerEventSessionOutputTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationServerEventSessionOutputTranscriptDeltaType value)
        {
            return value switch
            {
                RealtimeTranslationServerEventSessionOutputTranscriptDeltaType.SessionOutputTranscriptDelta => "session.output_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationServerEventSessionOutputTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "session.output_transcript.delta" => RealtimeTranslationServerEventSessionOutputTranscriptDeltaType.SessionOutputTranscriptDelta,
                _ => null,
            };
        }
    }
}