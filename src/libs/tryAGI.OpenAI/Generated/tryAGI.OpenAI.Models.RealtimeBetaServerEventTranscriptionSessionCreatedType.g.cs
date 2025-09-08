
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `transcription_session.created`.
    /// </summary>
    public enum RealtimeBetaServerEventTranscriptionSessionCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventTranscriptionSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventTranscriptionSessionCreatedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventTranscriptionSessionCreatedType.TranscriptionSessionCreated => "transcription_session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventTranscriptionSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "transcription_session.created" => RealtimeBetaServerEventTranscriptionSessionCreatedType.TranscriptionSessionCreated,
                _ => null,
            };
        }
    }
}