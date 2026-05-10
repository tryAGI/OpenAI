
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SemanticVad,
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType value)
        {
            return value switch
            {
                RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType.SemanticVad => "semantic_vad",
                RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "semantic_vad" => RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType.SemanticVad,
                "server_vad" => RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType.ServerVad,
                _ => null,
            };
        }
    }
}