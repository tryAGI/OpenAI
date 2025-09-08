
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`. `low`, `medium`, and `high` have max timeouts of 8s, 4s, and 2s respectively.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness
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
    public static class RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness.Low => "low",
                RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness.Medium => "medium",
                RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness.High => "high",
                RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness? ToEnum(string value)
        {
            return value switch
            {
                "low" => RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness.Low,
                "medium" => RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness.Medium,
                "high" => RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness.High,
                "auto" => RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness.Auto,
                _ => null,
            };
        }
    }
}