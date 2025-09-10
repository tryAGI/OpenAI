
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default tracing mode for the session.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionCreateResponseGATracingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseGATracingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGATracingEnum value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGATracingEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGATracingEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeSessionCreateResponseGATracingEnum.Auto,
                _ => null,
            };
        }
    }
}