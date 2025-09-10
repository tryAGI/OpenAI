
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    public enum RealtimeSessionCreateResponseGAAudioInputTurnDetectionType
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
    public static class RealtimeSessionCreateResponseGAAudioInputTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGAAudioInputTurnDetectionType value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGAAudioInputTurnDetectionType.ServerVad => "server_vad",
                RealtimeSessionCreateResponseGAAudioInputTurnDetectionType.SemanticVad => "semantic_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGAAudioInputTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeSessionCreateResponseGAAudioInputTurnDetectionType.ServerVad,
                "semantic_vad" => RealtimeSessionCreateResponseGAAudioInputTurnDetectionType.SemanticVad,
                _ => null,
            };
        }
    }
}