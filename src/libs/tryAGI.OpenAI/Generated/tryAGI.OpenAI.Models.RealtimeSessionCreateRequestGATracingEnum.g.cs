
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default tracing mode for the session.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionCreateRequestGATracingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestGATracingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestGATracingEnum value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestGATracingEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestGATracingEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeSessionCreateRequestGATracingEnum.Auto,
                _ => null,
            };
        }
    }
}