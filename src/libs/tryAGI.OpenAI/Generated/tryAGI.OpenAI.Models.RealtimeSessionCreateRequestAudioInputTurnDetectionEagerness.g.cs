
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestAudioInputTurnDetectionEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness.Low => "low",
                RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness.Medium => "medium",
                RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness.High => "high",
                RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness? ToEnum(string value)
        {
            return value switch
            {
                "low" => RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness.Low,
                "medium" => RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness.Medium,
                "high" => RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness.High,
                "auto" => RealtimeSessionCreateRequestAudioInputTurnDetectionEagerness.Auto,
                _ => null,
            };
        }
    }
}