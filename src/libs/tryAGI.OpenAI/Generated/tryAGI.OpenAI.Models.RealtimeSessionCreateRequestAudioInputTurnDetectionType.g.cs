
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    public enum RealtimeSessionCreateRequestAudioInputTurnDetectionType
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
    public static class RealtimeSessionCreateRequestAudioInputTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestAudioInputTurnDetectionType value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestAudioInputTurnDetectionType.ServerVad => "server_vad",
                RealtimeSessionCreateRequestAudioInputTurnDetectionType.SemanticVad => "semantic_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestAudioInputTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeSessionCreateRequestAudioInputTurnDetectionType.ServerVad,
                "semantic_vad" => RealtimeSessionCreateRequestAudioInputTurnDetectionType.SemanticVad,
                _ => null,
            };
        }
    }
}