
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`. `low`, `medium`, and `high` have max timeouts of 8s, 4s, and 2s respectively.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeTurnDetectionVariant2Eagerness
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
    public static class RealtimeTurnDetectionVariant2EagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTurnDetectionVariant2Eagerness value)
        {
            return value switch
            {
                RealtimeTurnDetectionVariant2Eagerness.Low => "low",
                RealtimeTurnDetectionVariant2Eagerness.Medium => "medium",
                RealtimeTurnDetectionVariant2Eagerness.High => "high",
                RealtimeTurnDetectionVariant2Eagerness.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTurnDetectionVariant2Eagerness? ToEnum(string value)
        {
            return value switch
            {
                "low" => RealtimeTurnDetectionVariant2Eagerness.Low,
                "medium" => RealtimeTurnDetectionVariant2Eagerness.Medium,
                "high" => RealtimeTurnDetectionVariant2Eagerness.High,
                "auto" => RealtimeTurnDetectionVariant2Eagerness.Auto,
                _ => null,
            };
        }
    }
}