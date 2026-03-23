
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`. `low`, `medium`, and `high` have max timeouts of 8s, 4s, and 2s respectively.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness value)
        {
            return value switch
            {
                RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness.Auto => "auto",
                RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness.High => "high",
                RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness.Low => "low",
                RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness.Auto,
                "high" => RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness.High,
                "low" => RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness.Low,
                "medium" => RealtimeTurnDetectionRealtimeTurnDetection1SemanticVadEagerness.Medium,
                _ => null,
            };
        }
    }
}