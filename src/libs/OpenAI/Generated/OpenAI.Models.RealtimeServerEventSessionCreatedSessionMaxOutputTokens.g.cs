
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeServerEventSessionCreatedSessionMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventSessionCreatedSessionMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventSessionCreatedSessionMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeServerEventSessionCreatedSessionMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventSessionCreatedSessionMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeServerEventSessionCreatedSessionMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}