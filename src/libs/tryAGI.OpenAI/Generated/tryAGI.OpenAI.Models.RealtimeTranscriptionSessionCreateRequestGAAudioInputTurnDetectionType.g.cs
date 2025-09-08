
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestGAAudioInputTurnDetectionType
    {
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
        /// <summary>
        /// 
        /// </summary>
        SemanticVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestGAAudioInputTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestGAAudioInputTurnDetectionType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestGAAudioInputTurnDetectionType.ServerVad => "server_vad",
                RealtimeTranscriptionSessionCreateRequestGAAudioInputTurnDetectionType.SemanticVad => "semantic_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestGAAudioInputTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeTranscriptionSessionCreateRequestGAAudioInputTurnDetectionType.ServerVad,
                "semantic_vad" => RealtimeTranscriptionSessionCreateRequestGAAudioInputTurnDetectionType.SemanticVad,
                _ => null,
            };
        }
    }
}