
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of turn detection.<br/>
    /// Default Value: server_vad
    /// </summary>
    public enum RealtimeSessionCreateRequestGAAudioInputTurnDetectionType
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
    public static class RealtimeSessionCreateRequestGAAudioInputTurnDetectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestGAAudioInputTurnDetectionType value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestGAAudioInputTurnDetectionType.ServerVad => "server_vad",
                RealtimeSessionCreateRequestGAAudioInputTurnDetectionType.SemanticVad => "semantic_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestGAAudioInputTurnDetectionType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeSessionCreateRequestGAAudioInputTurnDetectionType.ServerVad,
                "semantic_vad" => RealtimeSessionCreateRequestGAAudioInputTurnDetectionType.SemanticVad,
                _ => null,
            };
        }
    }
}