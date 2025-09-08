
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `transcription_session.update`.
    /// </summary>
    public enum RealtimeBetaClientEventTranscriptionSessionUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventTranscriptionSessionUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventTranscriptionSessionUpdateType value)
        {
            return value switch
            {
                RealtimeBetaClientEventTranscriptionSessionUpdateType.TranscriptionSessionUpdate => "transcription_session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventTranscriptionSessionUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "transcription_session.update" => RealtimeBetaClientEventTranscriptionSessionUpdateType.TranscriptionSessionUpdate,
                _ => null,
            };
        }
    }
}