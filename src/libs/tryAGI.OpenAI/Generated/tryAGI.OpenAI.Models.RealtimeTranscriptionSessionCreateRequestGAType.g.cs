
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of session to create. Always `transcription` for transcription sessions.
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestGAType
    {
        /// <summary>
        /// 
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestGATypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestGAType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestGAType.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestGAType? ToEnum(string value)
        {
            return value switch
            {
                "transcription" => RealtimeTranscriptionSessionCreateRequestGAType.Transcription,
                _ => null,
            };
        }
    }
}