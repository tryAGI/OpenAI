
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `transcription_session.created`.
    /// </summary>
    public enum RealtimeServerEventTranscriptionSessionCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventTranscriptionSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventTranscriptionSessionCreatedType value)
        {
            return value switch
            {
                RealtimeServerEventTranscriptionSessionCreatedType.TranscriptionSessionCreated => "transcription_session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventTranscriptionSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "transcription_session.created" => RealtimeServerEventTranscriptionSessionCreatedType.TranscriptionSessionCreated,
                _ => null,
            };
        }
    }
}