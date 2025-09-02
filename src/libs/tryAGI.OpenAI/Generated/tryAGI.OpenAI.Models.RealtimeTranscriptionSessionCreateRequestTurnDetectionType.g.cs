
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of turn detection. Only `server_vad` is currently supported for transcription sessions.
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestTurnDetectionType
    {
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestTurnDetectionType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestTurnDetectionType.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeTranscriptionSessionCreateRequestTurnDetectionType.ServerVad,
                _ => null,
            };
        }
    }
}