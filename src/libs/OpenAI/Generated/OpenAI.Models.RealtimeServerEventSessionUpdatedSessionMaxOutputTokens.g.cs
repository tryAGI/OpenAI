
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeServerEventSessionUpdatedSessionMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventSessionUpdatedSessionMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventSessionUpdatedSessionMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeServerEventSessionUpdatedSessionMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventSessionUpdatedSessionMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeServerEventSessionUpdatedSessionMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}