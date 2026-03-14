
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default tracing mode for the session.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionTracingTracingConfigurationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionTracingTracingConfigurationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionTracingTracingConfigurationEnum value)
        {
            return value switch
            {
                RealtimeSessionTracingTracingConfigurationEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionTracingTracingConfigurationEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeSessionTracingTracingConfigurationEnum.Auto,
                _ => null,
            };
        }
    }
}