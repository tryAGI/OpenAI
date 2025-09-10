
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`. `low`, `medium`, and `high` have max timeouts of 8s, 4s, and 2s respectively.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness
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
    public static class RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness.Low => "low",
                RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness.Medium => "medium",
                RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness.High => "high",
                RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness? ToEnum(string value)
        {
            return value switch
            {
                "low" => RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness.Low,
                "medium" => RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness.Medium,
                "high" => RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness.High,
                "auto" => RealtimeSessionCreateResponseGAAudioInputTurnDetectionEagerness.Auto,
                _ => null,
            };
        }
    }
}