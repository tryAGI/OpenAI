
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of turn detection, `semantic_vad` to turn on Semantic VAD.
    /// </summary>
    public enum RealtimeTurnDetectionVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        SemanticVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTurnDetectionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTurnDetectionVariant2Type value)
        {
            return value switch
            {
                RealtimeTurnDetectionVariant2Type.SemanticVad => "semantic_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTurnDetectionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "semantic_vad" => RealtimeTurnDetectionVariant2Type.SemanticVad,
                _ => null,
            };
        }
    }
}