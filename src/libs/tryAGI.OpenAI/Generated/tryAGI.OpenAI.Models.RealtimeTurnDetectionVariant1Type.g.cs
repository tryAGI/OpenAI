
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of turn detection, `server_vad` to turn on simple Server VAD.<br/>
    /// Default Value: server_vad
    /// </summary>
    public enum RealtimeTurnDetectionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTurnDetectionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTurnDetectionVariant1Type value)
        {
            return value switch
            {
                RealtimeTurnDetectionVariant1Type.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTurnDetectionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => RealtimeTurnDetectionVariant1Type.ServerVad,
                _ => null,
            };
        }
    }
}