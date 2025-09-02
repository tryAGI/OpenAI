
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of session to create. Always `transcription` for transcription sessions.
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestType.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "transcription" => RealtimeTranscriptionSessionCreateRequestType.Transcription,
                _ => null,
            };
        }
    }
}