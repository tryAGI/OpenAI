
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.input_transcript.delta`.
    /// </summary>
    public enum RealtimeTranslationServerEventSessionInputTranscriptDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionInputTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationServerEventSessionInputTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationServerEventSessionInputTranscriptDeltaType value)
        {
            return value switch
            {
                RealtimeTranslationServerEventSessionInputTranscriptDeltaType.SessionInputTranscriptDelta => "session.input_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationServerEventSessionInputTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_transcript.delta" => RealtimeTranslationServerEventSessionInputTranscriptDeltaType.SessionInputTranscriptDelta,
                _ => null,
            };
        }
    }
}