
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    public enum RealtimeSessionCreateResponseAudioInputTurnDetectionType
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
    public static class RealtimeSessionCreateResponseAudioInputTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseAudioInputTurnDetectionType value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseAudioInputTurnDetectionType.ServerVad => "server_vad",
                RealtimeSessionCreateResponseAudioInputTurnDetectionType.SemanticVad => "semantic_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseAudioInputTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeSessionCreateResponseAudioInputTurnDetectionType.ServerVad,
                "semantic_vad" => RealtimeSessionCreateResponseAudioInputTurnDetectionType.SemanticVad,
                _ => null,
            };
        }
    }
}