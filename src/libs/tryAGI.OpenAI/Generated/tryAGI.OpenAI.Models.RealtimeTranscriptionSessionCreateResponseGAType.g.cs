
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of session. Always `transcription` for transcription sessions.
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateResponseGAType
    {
        /// <summary>
        /// 
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateResponseGATypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateResponseGAType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateResponseGAType.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateResponseGAType? ToEnum(string value)
        {
            return value switch
            {
                "transcription" => RealtimeTranscriptionSessionCreateResponseGAType.Transcription,
                _ => null,
            };
        }
    }
}