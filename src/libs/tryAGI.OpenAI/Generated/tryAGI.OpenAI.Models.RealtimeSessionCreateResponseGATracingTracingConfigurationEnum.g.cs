
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Enables tracing and sets default values for tracing configuration options. Always `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionCreateResponseGATracingTracingConfigurationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseGATracingTracingConfigurationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGATracingTracingConfigurationEnum value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGATracingTracingConfigurationEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGATracingTracingConfigurationEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeSessionCreateResponseGATracingTracingConfigurationEnum.Auto,
                _ => null,
            };
        }
    }
}