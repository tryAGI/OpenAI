
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `transcription_session.updated`.
    /// </summary>
    public enum RealtimeBetaServerEventTranscriptionSessionUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventTranscriptionSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventTranscriptionSessionUpdatedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventTranscriptionSessionUpdatedType.TranscriptionSessionUpdated => "transcription_session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventTranscriptionSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "transcription_session.updated" => RealtimeBetaServerEventTranscriptionSessionUpdatedType.TranscriptionSessionUpdated,
                _ => null,
            };
        }
    }
}